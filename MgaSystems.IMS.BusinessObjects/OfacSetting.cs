// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.OfacSetting
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblOFACSettings")]
public abstract class OfacSetting : BaseDataObject, IOfacSetting
{
  protected int _ofacTypeId;
  private DateTime _nextUpdate;

  protected OfacSetting(int ofacId)
  {
    this.SearchesRemaining = -1;
    this._nextUpdate = DateTime.Now;
    this.OfacTypeID = ofacId;
    this.AllowMissingRecord = true;
  }

  [DataKey]
  public int OfacTypeID
  {
    get => this._ofacTypeId;
    protected set
    {
      this._ofacTypeId = this._ofacTypeId <= 0 ? value : throw new InvalidOperationException($"Specified {this.GetType().Name} {this._ofacTypeId} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int SortOrder
  {
    get => this.GetField<int?>(nameof (SortOrder), nameof (SortOrder)) ?? int.MaxValue;
  }

  public virtual bool IsValid
  {
    get
    {
      bool isValid;
      try
      {
        if (this.ShouldRefresh)
          this.RefreshData();
        isValid = this.ServiceEnabled;
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        ex2.Data.Add((object) "OfacTypeID", (object) this.OfacTypeID);
        ex2.Data.Add((object) "Type", (object) this.GetType().FullName);
        ErrorHandler.SilentLogError(ex2);
        isValid = false;
        ProjectData.ClearProjectError();
      }
      return isValid;
    }
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
    get => this.GetField<bool?>(nameof (ServiceEnabled), nameof (ServiceEnabled)) ?? false;
  }

  [TableFieldMapping]
  public bool LoggingEnabled
  {
    get => this.GetField<bool?>(nameof (LoggingEnabled), nameof (LoggingEnabled)) ?? false;
  }

  public int SearchesRemaining { get; set; }

  protected override void OnDataRefresh(bool refreshed)
  {
    if (!refreshed)
      return;
    this._nextUpdate = DateTime.Now.AddMinutes(15.0);
    this.SearchesRemaining = -1;
  }

  protected bool ShouldRefresh
  {
    get => this.ObjectDataStore == null || DateTime.Compare(DateTime.Now, this._nextUpdate) > 0;
  }

  protected abstract bool LoadConfigurationSettings();

  protected T GetConfigurationSetting<T>(string settingName, T defaultValue)
  {
    T configurationSetting;
    try
    {
      configurationSetting = !this.LoadConfigurationSettings() ? defaultValue : this.GetField<T>(settingName, nameof (GetConfigurationSetting)) ?? defaultValue;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      configurationSetting = defaultValue;
      ProjectData.ClearProjectError();
    }
    return configurationSetting;
  }

  protected virtual int OfacHitThreshold => MGASystems.Common.Settings.SystemSettings.GetSetting<int>("ScoreNumber", 100);

  public virtual OfacSystem.OfacResult CheckEntityOfac(IOfacEntity entity)
  {
    return this.CheckOfac(entity.GetSearchCriteria((IOfacSetting) this));
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

  public abstract bool IsOfacSearchValid(OfacSystem.OfacStatus ofacSearch);

  public virtual bool IsOfacSearchHit(OfacSystem.OfacStatus ofacSearch)
  {
    return ofacSearch != null && ofacSearch.HitDate.HasValue;
  }

  public virtual string OfacHitMessage(OfacSystem.OfacStatus ofacSearch)
  {
    return $"The {ofacSearch.EntityType} OFAC is not in system compliance";
  }

  public virtual bool IsOfacSearchCleared(OfacSystem.OfacStatus ofacSearch)
  {
    return ofacSearch == null || ofacSearch.IsOfacCleared;
  }

  public virtual void HandleWebException(
    WebException webEx,
    Action<string, string> ofacSystemErrorHandler)
  {
    if (ofacSystemErrorHandler == null)
      return;
    ofacSystemErrorHandler("The OFAC Service is experiencing an error and an OFAC report can not be captured.", "OFAC Service Offline");
  }

  public virtual void HandleException(Exception ex, Action<string, string> ofacSystemErrorHandler)
  {
    if (ofacSystemErrorHandler == null)
      return;
    ofacSystemErrorHandler("The OFAC Service is experiencing a general error and an OFAC report can not be captured.", "OFAC Service General Error");
  }

  public virtual DataSet GetOfacDataset(OfacSystem.OfacStatus status)
  {
    return this.GetXmlDataset(status?.OfacXml);
  }

  public virtual DataSet GetXmlDataset(string ofacXml)
  {
    DataSet xmlDataset;
    if (string.IsNullOrEmpty(ofacXml))
    {
      xmlDataset = (DataSet) null;
    }
    else
    {
      DataSet dataSet = new DataSet();
      try
      {
        int num = (int) dataSet.ReadXml((TextReader) new StringReader(ofacXml));
        try
        {
          IEnumerable<DataTable> source1 = dataSet.Tables.OfType<DataTable>();
          System.Func<DataTable, IEnumerable<DataColumn>> selector;
          // ISSUE: reference to a compiler-generated field
          if (OfacSetting._Closure\u0024__.\u0024I45\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector = OfacSetting._Closure\u0024__.\u0024I45\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            OfacSetting._Closure\u0024__.\u0024I45\u002D0 = selector = (System.Func<DataTable, IEnumerable<DataColumn>>) ([SpecialName] (dt) =>
            {
              IEnumerable<DataColumn> source2 = dt.Columns.OfType<DataColumn>();
              System.Func<DataColumn, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (OfacSetting._Closure\u0024__.\u0024I45\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = OfacSetting._Closure\u0024__.\u0024I45\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                OfacSetting._Closure\u0024__.\u0024I45\u002D1 = predicate = (System.Func<DataColumn, bool>) ([SpecialName] (tc) => tc.DataType == typeof (string));
              }
              return source2.Where<DataColumn>(predicate);
            });
          }
          IEnumerable<DataColumn> source3 = source1.SelectMany<DataTable, DataColumn>(selector);
          System.Func<DataColumn, bool> predicate1;
          // ISSUE: reference to a compiler-generated field
          if (OfacSetting._Closure\u0024__.\u0024I45\u002D2 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate1 = OfacSetting._Closure\u0024__.\u0024I45\u002D2;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            OfacSetting._Closure\u0024__.\u0024I45\u002D2 = predicate1 = (System.Func<DataColumn, bool>) ([SpecialName] (tc) =>
            {
              // ISSUE: variable of a compiler-generated type
              OfacSetting._Closure\u0024__45\u002D0 closure450_1;
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              OfacSetting._Closure\u0024__45\u002D0 closure450_2 = new OfacSetting._Closure\u0024__45\u002D0(closure450_1);
              // ISSUE: reference to a compiler-generated field
              closure450_2.\u0024VB\u0024Local_tc = tc;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              return closure450_2.\u0024VB\u0024Local_tc.Table.AsEnumerable().Select<DataRow, string>(new System.Func<DataRow, string>(closure450_2._Lambda\u0024__3)).All<string>(new System.Func<string, bool>(string.IsNullOrEmpty));
            });
          }
          foreach (DataColumn column in source3.Where<DataColumn>(predicate1).ToList<DataColumn>())
            column.Table.Columns.Remove(column);
        }
        finally
        {
          List<DataColumn>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentLogError(ex);
        ProjectData.ClearProjectError();
      }
      xmlDataset = dataSet;
    }
    return xmlDataset;
  }

  protected virtual void LogOfacSearch(Func<string> requestXmlFunc, Func<string> responseXmlFunc)
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
        requestXmlFunc != null ? (object) requestXmlFunc() : (object) (string) null,
        (object) "@response",
        responseXmlFunc != null ? (object) responseXmlFunc() : (object) (string) null
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentLogError(ex);
      ProjectData.ClearProjectError();
    }
  }
}
