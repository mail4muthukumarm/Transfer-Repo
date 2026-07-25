// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.OFAC.OfacSetting`1
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.Attributes;
using MGASystems.Common.Data;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.OFAC;

[TableMapping("dbo.tblOFACSettings")]
public abstract class OfacSetting<TSearch> : 
  CommonMappedObject<OfacSetting<TSearch>>,
  IOfacSearchSetting,
  IOfacSetting
{
  private DateTime _nextUpdate = DateTime.Now;

  protected OfacSetting(int ofacTypeId)
  {
    this.OfacTypeID = ofacTypeId;
    this.AllowMissingRecord = true;
  }

  [DataKey]
  public int OfacTypeID { get; }

  int IOfacSetting.SettingID => this.OfacTypeID;

  [TableFieldMapping]
  public int SortOrder
  {
    get => this.GetField<int?>(nameof (SortOrder), nameof (SortOrder)) ?? int.MaxValue;
  }

  [TableFieldMapping]
  public string OfacName => this.GetField<string>(nameof (OfacName), nameof (OfacName));

  [TableFieldMapping]
  public string ServiceURL => this.GetField<string>(nameof (ServiceURL), nameof (ServiceURL));

  [TableFieldMapping]
  public string ServiceUsername
  {
    get => this.GetField<string>(nameof (ServiceUsername), nameof (ServiceUsername));
  }

  [TableFieldMapping]
  public string ServicePassword
  {
    get => this.GetField<string>(nameof (ServicePassword), nameof (ServicePassword));
  }

  [TableFieldMapping]
  public string ServiceConfiguration
  {
    get => this.GetField<string>(nameof (ServiceConfiguration), nameof (ServiceConfiguration));
  }

  [TableFieldMapping]
  public bool ServiceEnabled
  {
    get => this.GetField<bool>(nameof (ServiceEnabled), nameof (ServiceEnabled));
  }

  [TableFieldMapping]
  public bool LoggingEnabled
  {
    get => this.GetField<bool>(nameof (LoggingEnabled), nameof (LoggingEnabled));
  }

  [OfacConfiguration]
  public int? ClearExpireDays
  {
    get => this.GetConfigurationSetting<int?>(nameof (ClearExpireDays), new int?());
  }

  [OfacConfiguration]
  public int? SearchExpireDays
  {
    get => this.GetConfigurationSetting<int?>(nameof (SearchExpireDays), new int?());
  }

  public int SearchesRemaining { get; private set; }

  public virtual bool IsValid
  {
    get
    {
      try
      {
        if (this.ShouldRefresh)
          this.RefreshData();
        return this.ServiceEnabled;
      }
      catch (Exception ex)
      {
        base.SilentHandleError(ex);
      }
      return false;
    }
  }

  protected override void OnDataRefreshed(bool refreshed)
  {
    if (refreshed)
    {
      this._nextUpdate = DateTime.Now.AddMinutes(15.0);
      this.SearchesRemaining = 1;
    }
    base.OnDataRefreshed(refreshed);
  }

  protected bool ShouldRefresh => this.ObjectDataStore == null || DateTime.Now > this._nextUpdate;

  protected virtual bool LoadConfigurationSettings()
  {
    try
    {
      if (!this.HasValues("ClearExpireDays", "SearchExpireDays"))
        this.TryAddValue<int?>("ClearExpireDays", (int?) XElement.Parse(this.ServiceConfiguration).Element((XName) "ClearExpireDays"));
      return true;
    }
    catch
    {
      return false;
    }
  }

  protected TSetting GetConfigurationSetting<TSetting>(string settingName, TSetting defaultValue)
  {
    try
    {
      if (this.LoadConfigurationSettings())
      {
        TSetting field = this.GetField<TSetting>(settingName, nameof (GetConfigurationSetting));
        if ((object) field != null)
        {
          if (!OfacSetting<TSearch>.IsNullOrDefault<TSetting>(field))
            return field;
        }
      }
    }
    catch (Exception ex)
    {
      ex.Data[(object) nameof (settingName)] = (object) settingName;
      ex.Data[(object) nameof (defaultValue)] = (object) defaultValue;
      base.SilentHandleError(ex);
    }
    return defaultValue;
  }

  private static bool IsNullOrDefault<TEqual>(TEqual value)
  {
    return (object) value == null || EqualityComparer<TEqual>.Default.Equals(value, default (TEqual));
  }

  protected override void SilentHandleError(Exception ex)
  {
    ex.Data[(object) "OfacTypeID"] = (object) this.OfacTypeID;
    base.SilentHandleError(ex);
  }

  protected override void HandleError(Exception ex)
  {
    ex.Data[(object) "OfacTypeID"] = (object) this.OfacTypeID;
    base.HandleError(ex);
  }

  protected virtual int OfacHitThreshold => MGASystems.Common.Settings.SystemSettings.GetSetting<int>("ScoreNumber", 100);

  public virtual OfacSystem.OfacResult CheckEntityOfac(IOfacEntity entity)
  {
    return entity is IOfacSearchEntity entity1 ? this.CheckSearchEntityOfac(entity1) : this.CheckOfac(entity.GetSearchCriteria((IOfacSetting) this));
  }

  public virtual OfacSystem.OfacResult CheckOfac(
    Guid entityGuid,
    Guid? parentGuid,
    string entityType,
    string recreateTypeName,
    string lastName,
    string firstName = null,
    string address = null,
    string city = null,
    string state = null,
    string zipCode = null,
    string isoCountryCode = null,
    string dob = null)
  {
    return this.CheckOfac(new OfacSystem.OfacCriteria()
    {
      EntityGuid = entityGuid,
      ParentGuid = parentGuid,
      EntityType = entityType,
      RecreateTypeName = recreateTypeName,
      LastName = lastName,
      FirstName = firstName,
      Address = address,
      City = city,
      State = state,
      ZipCode = zipCode,
      IsoCountryCode = isoCountryCode,
      DateOfBirth = dob
    });
  }

  public abstract OfacSystem.OfacResult CheckOfac(OfacSystem.OfacCriteria criteria);

  public virtual OfacSystem.OfacResult CheckSearchEntityOfac(IOfacSearchEntity entity)
  {
    return this.CheckOfac(this.GetSettingSearchCriteria(entity));
  }

  public abstract OfacSystem.OfacCriteria GetSettingSearchCriteria(IOfacSearchEntity entity);

  public virtual DataSet GetOfacDataset(OfacSystem.OfacStatus status)
  {
    return this.GetXmlDataset(status?.OfacXml);
  }

  public virtual DataSet GetXmlDataset(string ofacXml)
  {
    if (string.IsNullOrEmpty(ofacXml))
      return (DataSet) null;
    DataSet xmlDataset = new DataSet();
    try
    {
      int num = (int) xmlDataset.ReadXml((TextReader) new StringReader(ofacXml));
      foreach (DataColumn column in xmlDataset.Tables.OfType<DataTable>().SelectMany<DataTable, DataColumn>((System.Func<DataTable, IEnumerable<DataColumn>>) (table => table.Columns.OfType<DataColumn>().Where<DataColumn>((System.Func<DataColumn, bool>) (col => col.DataType == typeof (string))))).Where<DataColumn>((System.Func<DataColumn, bool>) (checkCol => checkCol.Table.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (row => row.Field<string>(checkCol))).All<string>(new System.Func<string, bool>(string.IsNullOrEmpty)))).ToList<DataColumn>())
        column.Table.Columns.Remove(column);
    }
    catch (Exception ex)
    {
      this.HandleError(ex);
    }
    return xmlDataset;
  }

  public virtual void HandleException(Exception ex, Action<string, string> ofacSystemErrorHandler)
  {
    if (ofacSystemErrorHandler == null)
      return;
    ofacSystemErrorHandler("The OFAC Service is experiencing a general error and an OFAC report can not be captured.", "OFAC Service General Error");
  }

  public virtual void HandleWebException(
    WebException webEx,
    Action<string, string> ofacSystemErrorHandler)
  {
    if (ofacSystemErrorHandler == null)
      return;
    ofacSystemErrorHandler("The OFAC Service is experiencing an error and an OFAC report can not be captured.", "OFAC Service Offline");
  }

  public virtual bool IsOfacSearchCleared(OfacSystem.OfacStatus ofacSearch)
  {
    return ofacSearch == null || ofacSearch.IsOfacCleared;
  }

  public virtual bool IsOfacSearchHit(OfacSystem.OfacStatus ofacSearch)
  {
    return ofacSearch != null && ofacSearch.HitDate.HasValue;
  }

  public virtual string OfacHitMessage(OfacSystem.OfacStatus ofacSearch)
  {
    return $"The {ofacSearch.EntityType} OFAC is not in system compliance";
  }

  public virtual bool IsOfacSearchValid(OfacSystem.OfacStatus ofacSearch)
  {
    return this.ValidSearchAge(ofacSearch) && this.ValidClearAge(ofacSearch);
  }

  protected virtual bool ValidSearchAge(OfacSystem.OfacStatus ofacSearch)
  {
    if (!this.SearchExpireDays.HasValue)
      return true;
    double totalDays = (DateTime.Now - ofacSearch.LogDate).TotalDays;
    int? searchExpireDays = this.SearchExpireDays;
    double? nullable = searchExpireDays.HasValue ? new double?((double) searchExpireDays.GetValueOrDefault()) : new double?();
    double valueOrDefault = nullable.GetValueOrDefault();
    return totalDays <= valueOrDefault & nullable.HasValue;
  }

  protected virtual bool ValidClearAge(OfacSystem.OfacStatus ofacSearch)
  {
    if (!this.ClearExpireDays.HasValue || !ofacSearch.ClearDate.HasValue)
      return true;
    double totalDays = (DateTime.Now - ofacSearch.ClearDate.Value).TotalDays;
    int? clearExpireDays = this.ClearExpireDays;
    double? nullable = clearExpireDays.HasValue ? new double?((double) clearExpireDays.GetValueOrDefault()) : new double?();
    double valueOrDefault = nullable.GetValueOrDefault();
    return totalDays <= valueOrDefault & nullable.HasValue;
  }

  protected virtual void LogOfacSearch(
    Func<string> requestXmlFunction,
    Func<string> responseXmlFunction)
  {
    if (!this.LoggingEnabled)
      return;
    try
    {
      DefaultDatabase.ExecuteNonQuery("dbo.OFAC_LogSearch", new object[6]
      {
        (object) "@ofacTypeID",
        (object) this.OfacTypeID,
        (object) "@request",
        requestXmlFunction != null ? (object) requestXmlFunction() : (object) (string) null,
        (object) "@response",
        responseXmlFunction != null ? (object) responseXmlFunction() : (object) (string) null
      });
    }
    catch (Exception ex)
    {
      base.SilentHandleError(ex);
    }
  }

  protected virtual TSearch ClientProcessResult(TSearch result) => result;

  protected abstract bool IsOfacHit(TSearch result);

  protected abstract int GetReturnScore(TSearch result);
}
