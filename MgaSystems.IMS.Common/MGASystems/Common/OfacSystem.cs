// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.OfacSystem
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Attributes;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common;

public class OfacSystem
{
  public const string ErrorCode = "-1";
  private List<IOfacSetting> _ofacSettings;

  protected static ConcurrentDictionary<string, Type> OfacEntityTypes { get; } = new ConcurrentDictionary<string, Type>();

  public static OfacSystem Instance { get; } = ObjectFactory.Instance.CreateObjectAs<OfacSystem>();

  static OfacSystem()
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IOfacEntity));
    int index = 0;
    while (index < typeArray.Length)
    {
      Type type = typeArray[index];
      OfacSystem.OfacEntityTypes.TryAdd(type.Name, type);
      OfacEntityAttribute ofacEntityAttribute = type.GetCustomAttributes(typeof (OfacEntityAttribute), false).OfType<OfacEntityAttribute>().FirstOrDefault<OfacEntityAttribute>();
      if (!string.IsNullOrEmpty(ofacEntityAttribute?.EntityType))
        OfacSystem.OfacEntityTypes[ofacEntityAttribute.EntityType] = type;
      checked { ++index; }
    }
  }

  protected List<IOfacSetting> OfacSettings
  {
    get
    {
      if (this._ofacSettings == null || this._ofacSettings.Count == 0)
      {
        Dictionary<int, IOfacSetting> dictionary = new Dictionary<int, IOfacSetting>();
        Type[] typeArray = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IOfacSetting));
        int index = 0;
        while (index < typeArray.Length)
        {
          Type baseType = typeArray[index];
          try
          {
            if (!baseType.IsAbstract)
            {
              IOfacSetting ofacSetting = (IOfacSetting) ObjectFactory.Instance.CreateObject(baseType, typeof (IOfacSetting));
              if (dictionary.ContainsKey(ofacSetting.SettingID))
              {
                if (baseType.IsAssignableFrom(dictionary[ofacSetting.SettingID].GetType()))
                  goto label_8;
              }
              dictionary[ofacSetting.SettingID] = ofacSetting;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ErrorHandler.SilentHandleError(ex);
            ProjectData.ClearProjectError();
          }
label_8:
          checked { ++index; }
        }
        try
        {
          Dictionary<int, IOfacSetting>.ValueCollection values = dictionary.Values;
          System.Func<IOfacSetting, int> keySelector;
          if (OfacSystem._Closure\u0024__.\u0024I11\u002D0 != null)
            keySelector = OfacSystem._Closure\u0024__.\u0024I11\u002D0;
          else
            OfacSystem._Closure\u0024__.\u0024I11\u002D0 = keySelector = (System.Func<IOfacSetting, int>) ([SpecialName] (ofac) => ofac.SortOrder);
          this._ofacSettings = values.OrderBy<IOfacSetting, int>(keySelector).ToList<IOfacSetting>();
        }
        catch (Exception ex1)
        {
          ProjectData.SetProjectError(ex1);
          Exception ex2 = ex1;
          this._ofacSettings = new List<IOfacSetting>();
          ErrorHandler.SilentHandleError(ex2);
          ProjectData.ClearProjectError();
        }
      }
      return this._ofacSettings;
    }
  }

  public IOfacSetting ValidSetting
  {
    get
    {
      List<IOfacSetting> ofacSettings = this.OfacSettings;
      System.Func<IOfacSetting, bool> predicate;
      if (OfacSystem._Closure\u0024__.\u0024I13\u002D0 != null)
        predicate = OfacSystem._Closure\u0024__.\u0024I13\u002D0;
      else
        OfacSystem._Closure\u0024__.\u0024I13\u002D0 = predicate = (System.Func<IOfacSetting, bool>) ([SpecialName] (setting) => setting.IsValid);
      return ofacSettings.FirstOrDefault<IOfacSetting>(predicate);
    }
  }

  public bool HasValidSetting => this.ValidSetting != null;

  public IOfacSetting GetSetting(int ofacTypeId)
  {
    return this.OfacSettings.FirstOrDefault<IOfacSetting>((System.Func<IOfacSetting, bool>) ([SpecialName] (ofs) => ofs.SettingID == ofacTypeId));
  }

  public T GetSetting<T>(int ofacTypeId) where T : IOfacSetting => (T) this.GetSetting(ofacTypeId);

  public T GetSetting<T>() where T : IOfacSetting
  {
    return this.OfacSettings.OfType<T>().FirstOrDefault<T>();
  }

  private OfacSystem.OfacResult CallOfac(IOfacSetting setting, OfacSystem.OfacCriteria criteria)
  {
    return this.CallOfac(setting, criteria, new Action<string, string>(this.HandleError));
  }

  private OfacSystem.OfacResult CallOfac(
    IOfacSetting setting,
    OfacSystem.OfacCriteria criteria,
    Action<string, string> progress)
  {
    OfacSystem.OfacResult result = (OfacSystem.OfacResult) null;
    try
    {
      result = setting.CheckOfac(criteria);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      exception.Data.Add((object) "EntityGuid", (object) criteria.EntityGuid);
      exception.Data.Add((object) "ParentEntityGuid", (object) criteria.ParentGuid);
      exception.Data.Add((object) "Criteria", (object) criteria.SerializeCriteria());
      ErrorHandler.WriteLog(exception);
      if (exception is WebException)
        setting.HandleWebException((WebException) exception, progress);
      else
        setting.HandleException(exception, progress);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.LogOfacResult(result);
    }
    return result;
  }

  private void HandleError(string message, string caption)
  {
    if (MDIControls.Instance.BlackBoxMode || MDIControls.Instance?.MDIParent == null)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new Action<string, string>(this.HandleError), (object) message, (object) caption);
    }
    else
    {
      int num = (int) MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  public void LogOfacResult(OfacSystem.OfacResult result)
  {
    if (result == null)
      return;
    this.LogOfacSearch(result);
    if (result.OfacHit)
    {
      this.LogOfacHit(result);
    }
    else
    {
      if (!this.RemoveOfacHit(result.SearchCriteria.EntityGuid, result.SearchCriteria.ParentGuid))
        return;
      CurrentUser.Instance.LogAction("New search fell below score threshold, and is no longer an OFAC hit.", result.SearchCriteria.EntityGuid, nameof (OfacSystem));
    }
  }

  public OfacSystem.OfacResult CheckOfacResult(OfacSystem.OfacCriteria criteria)
  {
    IOfacSetting validSetting = this.ValidSetting;
    return validSetting != null ? this.CallOfac(validSetting, criteria) : (OfacSystem.OfacResult) null;
  }

  public OfacSystem.OfacResult CheckOfacResult(IOfacEntity entity)
  {
    IOfacSetting validSetting = this.ValidSetting;
    return validSetting != null ? this.CallOfac(validSetting, entity.GetSearchCriteria(validSetting)) : (OfacSystem.OfacResult) null;
  }

  public OfacSystem.OfacResult CheckOfacResult<TEntity>(TEntity entity) where TEntity : IOfacEntity
  {
    return this.CheckOfacResult((IOfacEntity) entity);
  }

  public OfacSystem.OfacResult CheckOfacResult(
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
    return this.CheckOfacResult(new OfacSystem.OfacCriteria()
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

  public string CheckOfacXml(OfacSystem.OfacCriteria criteria)
  {
    return this.CheckOfacResult(criteria)?.OfacXml;
  }

  public string CheckOfacXml(IOfacEntity entity) => this.CheckOfacResult(entity)?.OfacXml;

  public string CheckOfacXml<TEntity>(TEntity entity) where TEntity : IOfacEntity
  {
    return this.CheckOfacXml((IOfacEntity) entity);
  }

  public string CheckOfacXml(
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
    return this.CheckOfacXml(new OfacSystem.OfacCriteria()
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

  public bool CheckOfac(OfacSystem.OfacCriteria criteria)
  {
    return !string.IsNullOrEmpty(this.CheckOfacResult(criteria)?.OfacXml);
  }

  public bool CheckOfac(IOfacEntity entity)
  {
    return !string.IsNullOrEmpty(this.CheckOfacResult(entity)?.OfacXml);
  }

  public bool CheckOfac<TEntity>(TEntity entity) where TEntity : IOfacEntity
  {
    return this.CheckOfac((IOfacEntity) entity);
  }

  public bool CheckMultiple(List<IOfacEntity> entities, Action<string, string> progress)
  {
    return this.CheckMultiple<IOfacEntity>(entities.AsEnumerable<IOfacEntity>(), progress);
  }

  public bool CheckMultiple<TEntity>(IEnumerable<TEntity> entities, Action<string, string> progress) where TEntity : IOfacEntity
  {
    List<OfacSystem.OfacResult> source = this.CheckMultipleResult(entities.Cast<IOfacEntity>().ToList<IOfacEntity>(), progress);
    System.Func<OfacSystem.OfacResult, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__35<TEntity>.\u0024I35\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = OfacSystem._Closure\u0024__35<TEntity>.\u0024I35\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__35<TEntity>.\u0024I35\u002D0 = predicate = (System.Func<OfacSystem.OfacResult, bool>) ([SpecialName] (res) => !string.IsNullOrEmpty(res?.OfacXml));
    }
    return source.Any<OfacSystem.OfacResult>(predicate);
  }

  public virtual bool CheckMultiple(
    List<OfacSystem.OfacCriteria> entities,
    Action<string, string> progress)
  {
    List<OfacSystem.OfacResult> source = this.CheckMultipleResult(entities, progress);
    System.Func<OfacSystem.OfacResult, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__.\u0024I36\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = OfacSystem._Closure\u0024__.\u0024I36\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__.\u0024I36\u002D0 = predicate = (System.Func<OfacSystem.OfacResult, bool>) ([SpecialName] (res) => !string.IsNullOrEmpty(res?.OfacXml));
    }
    return source.Any<OfacSystem.OfacResult>(predicate);
  }

  public virtual (int EntitiesSearched, bool AnyHits) CheckMultipleSummary(
    List<IOfacEntity> entities,
    Action<string, string> progress)
  {
    return this.CheckMultipleSummary<IOfacEntity>(entities.AsEnumerable<IOfacEntity>(), progress);
  }

  public virtual (int EntitiesSearched, bool AnyHits) CheckMultipleSummary<TEntity>(
    IEnumerable<TEntity> entities,
    Action<string, string> progress)
    where TEntity : IOfacEntity
  {
    List<OfacSystem.OfacResult> source1 = this.CheckMultipleResult<TEntity>(entities, progress);
    IEnumerable<OfacSystem.OfacResult> source2 = source1.AsEnumerable<OfacSystem.OfacResult>();
    System.Func<OfacSystem.OfacResult, bool> predicate1;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__38<TEntity>.\u0024I38\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate1 = OfacSystem._Closure\u0024__38<TEntity>.\u0024I38\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__38<TEntity>.\u0024I38\u002D0 = predicate1 = (System.Func<OfacSystem.OfacResult, bool>) ([SpecialName] (res) => !string.IsNullOrEmpty(res.OfacXml));
    }
    int num1 = source2.Count<OfacSystem.OfacResult>(predicate1);
    List<OfacSystem.OfacResult> source3 = source1;
    System.Func<OfacSystem.OfacResult, bool> predicate2;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__38<TEntity>.\u0024I38\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate2 = OfacSystem._Closure\u0024__38<TEntity>.\u0024I38\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__38<TEntity>.\u0024I38\u002D1 = predicate2 = (System.Func<OfacSystem.OfacResult, bool>) ([SpecialName] (res) => res.OfacHit);
    }
    int num2 = source3.Any<OfacSystem.OfacResult>(predicate2) ? 1 : 0;
    return (num1, num2 != 0);
  }

  public virtual (int EntitiesSearched, bool AnyHits) CheckMultipleSummary(
    List<OfacSystem.OfacCriteria> entities,
    Action<string, string> progress)
  {
    List<OfacSystem.OfacResult> source1 = this.CheckMultipleResult(entities, progress);
    IEnumerable<OfacSystem.OfacResult> source2 = source1.AsEnumerable<OfacSystem.OfacResult>();
    System.Func<OfacSystem.OfacResult, bool> predicate1;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__.\u0024I39\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate1 = OfacSystem._Closure\u0024__.\u0024I39\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__.\u0024I39\u002D0 = predicate1 = (System.Func<OfacSystem.OfacResult, bool>) ([SpecialName] (res) => !string.IsNullOrEmpty(res.OfacXml));
    }
    int num1 = source2.Count<OfacSystem.OfacResult>(predicate1);
    List<OfacSystem.OfacResult> source3 = source1;
    System.Func<OfacSystem.OfacResult, bool> predicate2;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__.\u0024I39\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate2 = OfacSystem._Closure\u0024__.\u0024I39\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__.\u0024I39\u002D1 = predicate2 = (System.Func<OfacSystem.OfacResult, bool>) ([SpecialName] (res) => res.OfacHit);
    }
    int num2 = source3.Any<OfacSystem.OfacResult>(predicate2) ? 1 : 0;
    return (num1, num2 != 0);
  }

  public virtual List<OfacSystem.OfacResult> CheckMultipleResult(
    List<IOfacEntity> entities,
    Action<string, string> progress)
  {
    return this.CheckMultipleResult<IOfacEntity>(entities.AsEnumerable<IOfacEntity>(), progress);
  }

  public virtual List<OfacSystem.OfacResult> CheckMultipleResult<TEntity>(
    IEnumerable<TEntity> entities,
    Action<string, string> progress)
    where TEntity : IOfacEntity
  {
    IOfacSetting validSetting = this.ValidSetting;
    return validSetting == null || !entities.Any<TEntity>() ? new List<OfacSystem.OfacResult>() : this.CallMultipleOfac(validSetting, entities.Select<TEntity, OfacSystem.OfacCriteria>((System.Func<TEntity, OfacSystem.OfacCriteria>) ([SpecialName] (ent) =>
    {
      ref \u0024CLS0 local = ref ent;
      if ((object) default (\u0024CLS0) == null)
      {
        \u0024CLS0 clS0 = local;
        local = ref clS0;
      }
      IOfacSetting ofacSetting = validSetting;
      return local.GetSearchCriteria(ofacSetting);
    })), progress);
  }

  public virtual List<OfacSystem.OfacResult> CheckMultipleResult(
    List<OfacSystem.OfacCriteria> entities,
    Action<string, string> progress)
  {
    IOfacSetting validSetting = this.ValidSetting;
    return validSetting == null || entities.Count == 0 ? new List<OfacSystem.OfacResult>() : this.CallMultipleOfac(validSetting, (IEnumerable<OfacSystem.OfacCriteria>) entities, progress);
  }

  protected virtual List<OfacSystem.OfacResult> CallMultipleOfac(
    IOfacSetting setting,
    IEnumerable<OfacSystem.OfacCriteria> entities,
    Action<string, string> progress)
  {
    progress = progress ?? new Action<string, string>(this.HandleError);
    List<OfacSystem.OfacResult> ofacResultList = new List<OfacSystem.OfacResult>();
    if (!(setting is ISearchOfacMultiple searchOfacMultiple))
    {
      List<Exception> exceptionList = new List<Exception>();
      try
      {
        foreach (OfacSystem.OfacCriteria entity in entities)
        {
          try
          {
            ofacResultList.Add(setting.CheckOfac(entity));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            exception.Data.Add((object) "EntityGuid", (object) entity.EntityGuid);
            exception.Data.Add((object) "EntityType", (object) entity.EntityType);
            exceptionList.Add(exception);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
        IEnumerator<OfacSystem.OfacCriteria> enumerator;
        enumerator?.Dispose();
      }
      if (exceptionList.Any<Exception>())
      {
        AggregateException ex = new AggregateException("One or more errors encountered during OFAC search", (IEnumerable<Exception>) exceptionList).Flatten();
        setting.HandleException((Exception) ex, progress);
        ErrorHandler.SilentHandleError((Exception) ex);
      }
    }
    else
    {
      try
      {
        ofacResultList.AddRange((IEnumerable<OfacSystem.OfacResult>) searchOfacMultiple.CheckMultipleOfac(entities.ToList<OfacSystem.OfacCriteria>(), progress));
      }
      catch (WebException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        WebException webEx = ex;
        setting.HandleWebException(webEx, progress);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        setting.HandleException(ex2, progress);
        ProjectData.ClearProjectError();
      }
    }
    try
    {
      foreach (OfacSystem.OfacResult result in ofacResultList)
        this.LogOfacResult(result);
    }
    finally
    {
      List<OfacSystem.OfacResult>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return ofacResultList;
  }

  public bool CheckOfac(
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

  public OfacSystem.OfacResult SearchByEntityGuid(string entityType, Guid entityGuid)
  {
    OfacSystem.OfacResult ofacResult = (OfacSystem.OfacResult) null;
    Type baseType = (Type) null;
    if (OfacSystem.OfacEntityTypes.TryGetValue(entityType, out baseType))
    {
      try
      {
        ofacResult = this.CheckOfacResult((IOfacEntity) ObjectFactory.Instance.CreateObjectEX(baseType, typeof (IOfacEntity), (object) entityGuid));
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        ex2.Data.Add((object) "EntityType", (object) baseType);
        ex2.Data.Add((object) "EntityGuid", (object) entityGuid);
        ErrorHandler.SilentLogError(ex2);
        if (ex2 is MissingMethodException && !OfacSystem.OfacEntityTypes.TryRemove(entityType, out baseType))
          ErrorHandler.SilentLogError(new Exception($"Unable to remove {baseType.FullName} from EntityType mappings."));
        ProjectData.ClearProjectError();
      }
    }
    return ofacResult;
  }

  public void LogOfacSearch(OfacSystem.OfacResult result)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.OFAC_SaveOfacResult", new object[22]
    {
      (object) "@EntityGUID",
      (object) result.SearchCriteria.EntityGuid,
      (object) "@ParentEntityGUID",
      (object) result.SearchCriteria.ParentGuid,
      (object) "@EntityName",
      (object) result.SearchCriteria.PolicyName,
      (object) "@EntityType",
      (object) result.SearchCriteria.EntityType,
      (object) "@RecreateTypeName",
      (object) result.SearchCriteria.RecreateTypeName,
      (object) "@OfacTypeID",
      (object) result.OfacTypeID,
      (object) "@OfacXml",
      (object) result.OfacXml,
      (object) "@ReturnCode",
      (object) result.ReturnCode,
      (object) "@ReturnScore",
      (object) result.ReturnScore,
      (object) "@ErrorDescription",
      (object) result.ErrorDescription,
      (object) "@SearchCriteria",
      (object) result.SearchCriteria.SerializeCriteria()
    });
    this.OnOfacSearch(result);
  }

  protected void LogOfacHit(OfacSystem.OfacResult result)
  {
    this.LogOfacHit(result.SearchCriteria.EntityGuid, result.SearchCriteria.ParentGuid, result.OfacScore);
  }

  public void LogOfacHit(Guid entityGuid, Guid? parentGuid, int ofacScore)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.OFAC_LogHit", new object[6]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@parentEntityGuid",
      (object) parentGuid,
      (object) "@ofacScore",
      (object) ofacScore
    });
    CurrentUser.Instance.LogAction("OFAC Hit", entityGuid, nameof (OfacSystem));
  }

  public void ClearOfacHit(
    Guid entityGuid,
    Guid? parentGuid,
    Guid? clearedByUserGuid = null,
    DateTime? clearDate = null,
    string clearReason = "",
    int? clearReasonId = null,
    string clearNotes = null)
  {
    clearedByUserGuid = new Guid?(clearedByUserGuid.HasValue ? clearedByUserGuid.GetValueOrDefault() : CurrentUser.Instance.UserGUID);
    DefaultDatabase.ExecuteNonQuery("dbo.OFAC_ClearHitStatus", new object[14]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@parentEntityGuid",
      (object) parentGuid,
      (object) "@clearedByUserGuid",
      (object) clearedByUserGuid,
      (object) "@clearDate",
      (object) clearDate,
      (object) "@clearReason",
      clearReasonId.HasValue ? (object) (string) null : (object) clearReason,
      (object) "@clearReasonId",
      (object) clearReasonId,
      (object) "@clearNotes",
      (object) clearNotes
    });
    OfacClearContext clear = new OfacClearContext(entityGuid, parentGuid, clearedByUserGuid.Value, clearDate, clearReason, clearReasonId, clearNotes);
    if (!string.IsNullOrEmpty(clearReason))
      clearReason = $"{(clearDate.HasValue ? (object) "cleared" : (object) "updated")} with reason \"{clearReason}\"";
    CurrentUser.Instance.LogAction($"OFAC hit status {clearReason}.", entityGuid, nameof (OfacSystem));
    this.OnOfacCleared(clear);
  }

  public void ReinstateOfacHit(Guid entityGuid, Guid? parentGuid)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.OFAC_ReinstateOfacHit", new object[4]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@parentEntityGuid",
      (object) parentGuid
    });
    CurrentUser.Instance.LogAction("Reinstated OFAC Hit.", entityGuid, nameof (OfacSystem));
    this.OnOfacReinstated(new OfacClearContext(entityGuid, parentGuid, CurrentUser.Instance.UserGUID, new DateTime?(), (string) null, new int?(), (string) null));
  }

  public bool RemoveOfacSearch(Guid entityGuid, Guid? parentGuid, bool deleteHit = false)
  {
    return this.RemoveOfacData(entityGuid, parentGuid, true, deleteHit);
  }

  public bool RemoveOfacHit(Guid entityGuid, Guid? parentGuid)
  {
    return this.RemoveOfacData(entityGuid, parentGuid, false, true);
  }

  public bool RemoveOfacData(Guid entityGuid, Guid? parentGuid, bool deleteOfac, bool deleteHit)
  {
    bool flag;
    if (DefaultDatabase.ExecuteScalar<int>("dbo.OFAC_DeleteOfacData", new object[8]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@parentEntityGuid",
      (object) parentGuid,
      (object) "@deleteOfac",
      (object) deleteOfac,
      (object) "@deleteHit",
      (object) deleteHit
    }) > 0)
    {
      this.OnOfacReset(new OfacResetContext(entityGuid, parentGuid, deleteOfac, deleteHit));
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  public bool EntityHasHit(Guid entityGuid, Guid? parentGuid)
  {
    OfacSystem.OfacStatus entityStatus = this.GetEntityStatus(entityGuid, parentGuid);
    return (entityStatus != null ? (entityStatus.OFACCleared ? 1 : 0) : 1) == 0;
  }

  public bool EntityHasHit(IOfacEntity entity)
  {
    OfacSystem.OfacStatus entityStatus = this.GetEntityStatus(entity);
    return (entityStatus != null ? (entityStatus.OFACCleared ? 1 : 0) : 1) == 0;
  }

  public bool AnyEntityHasHit(params IOfacEntity[] entities)
  {
    return this.AnyEntityHasHit((ICollection<IOfacEntity>) entities);
  }

  public bool AnyEntityHasHit(ICollection<IOfacEntity> entities)
  {
    ICollection<IOfacEntity> source = entities;
    System.Func<IOfacEntity, (Guid, Guid?)> selector;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__.\u0024I57\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = OfacSystem._Closure\u0024__.\u0024I57\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__.\u0024I57\u002D0 = selector = (System.Func<IOfacEntity, (Guid, Guid?)>) ([SpecialName] (ofac) => (ofac.EntityGuid, ofac.ParentEntityGuid));
    }
    return this.AnyEntityHasHit((ICollection<(Guid, Guid?)>) source.Select<IOfacEntity, (Guid, Guid?)>(selector).ToList<(Guid, Guid?)>());
  }

  public bool AnyEntityHasHit(params (Guid, Guid?)[] entities)
  {
    return this.AnyEntityHasHit((ICollection<(Guid, Guid?)>) entities);
  }

  public bool AnyEntityHasHit(ICollection<(Guid, Guid?)> entities)
  {
    List<OfacSystem.OfacStatus> multipleEntityStatus = this.GetMultipleEntityStatus(entities);
    bool flag = true;
    try
    {
      foreach (OfacSystem.OfacStatus ofacStatus in multipleEntityStatus)
        flag = flag && ofacStatus.OFACCleared;
    }
    finally
    {
      List<OfacSystem.OfacStatus>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return !flag;
  }

  public virtual OfacSystem.OfacStatus GetEntityStatus(IOfacEntity entity)
  {
    return this.GetEntityStatus(entity.EntityGuid, entity.ParentEntityGuid);
  }

  public virtual OfacSystem.OfacStatus GetEntityStatus(Guid entityGuid, Guid? parentGuid)
  {
    OfacSystem.OfacStatus ofacStatus = (OfacSystem.OfacStatus) null;
    OfacSystem.OfacStatus entityStatus;
    try
    {
      entityStatus = this.EntityTableToStatus(DefaultDatabase.ExecuteDataTable("dbo.OFAC_GetClearStatus", new object[4]
      {
        (object) "@entityGuid",
        (object) entityGuid,
        (object) "@parentEntityGuid",
        (object) parentGuid
      })).FirstOrDefault<OfacSystem.OfacStatus>();
      goto label_4;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "EntityGuid", (object) entityGuid.ToString());
      ex2.Data.Add((object) "ParentEntityGuid", parentGuid.HasValue ? (object) parentGuid.ToString() : (object) "{NULL}");
      ErrorHandler.WriteLog(ex2);
      ProjectData.ClearProjectError();
    }
    entityStatus = ofacStatus;
label_4:
    return entityStatus;
  }

  public virtual List<OfacSystem.OfacStatus> GetChildEntityStatus(IOfacEntity entity)
  {
    return this.GetChildEntityStatus(entity.ParentEntityGuid ?? Guid.Empty);
  }

  public virtual List<OfacSystem.OfacStatus> GetChildEntityStatus(Guid parentEntityGuid)
  {
    List<OfacSystem.OfacStatus> childEntityStatus;
    try
    {
      if (!Guid.Empty.Equals(parentEntityGuid))
      {
        childEntityStatus = this.EntityTableToStatus(DefaultDatabase.ExecuteDataTable("dbo.OFAC_GetClearStatus_Children", new object[2]
        {
          (object) "@parentEntityGuid",
          (object) parentEntityGuid
        }));
        goto label_4;
      }
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "ParentEntityGuid", (object) parentEntityGuid);
      ErrorHandler.WriteLog(ex2);
      ProjectData.ClearProjectError();
    }
    childEntityStatus = new List<OfacSystem.OfacStatus>();
label_4:
    return childEntityStatus;
  }

  public virtual List<OfacSystem.OfacStatus> GetMultipleEntityStatus(params IOfacEntity[] entities)
  {
    return this.GetMultipleEntityStatus((ICollection<IOfacEntity>) entities);
  }

  public virtual List<OfacSystem.OfacStatus> GetMultipleEntityStatus(
    ICollection<IOfacEntity> entities)
  {
    ICollection<IOfacEntity> source = entities;
    System.Func<IOfacEntity, (Guid, Guid?)> selector;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__.\u0024I65\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = OfacSystem._Closure\u0024__.\u0024I65\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__.\u0024I65\u002D0 = selector = (System.Func<IOfacEntity, (Guid, Guid?)>) ([SpecialName] (ofent) => (ofent.EntityGuid, ofent.ParentEntityGuid));
    }
    return this.GetMultipleEntityStatus((ICollection<(Guid, Guid?)>) source.Select<IOfacEntity, (Guid, Guid?)>(selector).ToList<(Guid, Guid?)>());
  }

  public virtual List<OfacSystem.OfacStatus> GetMultipleEntityStatus(params (Guid, Guid?)[] entities)
  {
    return this.GetMultipleEntityStatus((ICollection<(Guid, Guid?)>) entities);
  }

  public virtual List<OfacSystem.OfacStatus> GetMultipleEntityStatus(
    ICollection<(Guid, Guid?)> entities)
  {
    XName name = (XName) "Entities";
    ICollection<(Guid, Guid?)> source = entities;
    System.Func<(Guid, Guid?), XElement> selector;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__.\u0024I67\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = OfacSystem._Closure\u0024__.\u0024I67\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__.\u0024I67\u002D0 = selector = (System.Func<(Guid, Guid?), XElement>) ([SpecialName] (ent) => new XElement((XName) "Entity", new object[2]
      {
        (object) new XAttribute((XName) "EntityGuid", (object) ent.Item1),
        ent.Item2.HasValue ? (object) new XAttribute((XName) "ParentEntityGuid", (object) ent.Item2) : (object) (XAttribute) null
      }));
    }
    IEnumerable<XElement> content = source.Select<(Guid, Guid?), XElement>(selector);
    XElement xelement = new XElement(name, (object) content);
    List<OfacSystem.OfacStatus> multipleEntityStatus;
    try
    {
      multipleEntityStatus = this.EntityTableToStatus(DefaultDatabase.ExecuteDataTable("dbo.OFAC_GetClearStatus_Multiple", new object[2]
      {
        (object) "@entityXml",
        (object) xelement.ToString()
      }));
      goto label_7;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "Entities", (object) entities);
      ErrorHandler.WriteLog(ex2);
      ProjectData.ClearProjectError();
    }
    multipleEntityStatus = new List<OfacSystem.OfacStatus>();
label_7:
    return multipleEntityStatus;
  }

  public virtual Dictionary<TEntity, OfacSystem.OfacStatus> GetMultipleEntityDictionary<TEntity>(
    params TEntity[] entities)
    where TEntity : IOfacEntity
  {
    return this.GetMultipleEntityDictionary<TEntity>((ICollection<TEntity>) entities);
  }

  public virtual Dictionary<TEntity, OfacSystem.OfacStatus> GetMultipleEntityDictionary<TEntity>(
    ICollection<TEntity> entities)
    where TEntity : IOfacEntity
  {
    XName name = (XName) "Entities";
    ICollection<TEntity> source1 = entities;
    System.Func<TEntity, XElement> selector;
    // ISSUE: reference to a compiler-generated field
    if (OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D0 = selector = (System.Func<TEntity, XElement>) ([SpecialName] (ent) => new XElement((XName) "Entity", new object[2]
      {
        (object) new XAttribute((XName) "EntityGuid", (object) ent.EntityGuid),
        ent.ParentEntityGuid.HasValue ? (object) new XAttribute((XName) "ParentEntityGuid", (object) ent.ParentEntityGuid) : (object) (XAttribute) null
      }));
    }
    IEnumerable<XElement> content = source1.Select<TEntity, XElement>(selector);
    XElement xelement = new XElement(name, (object) content);
    Dictionary<TEntity, OfacSystem.OfacStatus> entityDictionary;
    try
    {
      DataTable hitTable = DefaultDatabase.ExecuteDataTable("dbo.OFAC_GetClearStatus_Multiple", new object[2]
      {
        (object) "@entityXml",
        (object) xelement.ToString()
      });
      ICollection<TEntity> outer = entities;
      List<OfacSystem.OfacStatus> status = this.EntityTableToStatus(hitTable);
      System.Func<TEntity, (Guid, Guid?)> outerKeySelector;
      // ISSUE: reference to a compiler-generated field
      if (OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        outerKeySelector = OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D1 = outerKeySelector = (System.Func<TEntity, (Guid, Guid?)>) ([SpecialName] (ai) => (ai.EntityGuid, ai.ParentEntityGuid));
      }
      System.Func<OfacSystem.OfacStatus, (Guid, Guid?)> innerKeySelector;
      // ISSUE: reference to a compiler-generated field
      if (OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        innerKeySelector = OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D2 = innerKeySelector = (System.Func<OfacSystem.OfacStatus, (Guid, Guid?)>) ([SpecialName] (ofac) => (ofac.EntityGuid, ofac.ParentEntityGuid));
      }
      Func<TEntity, IEnumerable<OfacSystem.OfacStatus>, (TEntity, IEnumerable<OfacSystem.OfacStatus>)> resultSelector;
      // ISSUE: reference to a compiler-generated field
      if (OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D3 != null)
      {
        // ISSUE: reference to a compiler-generated field
        resultSelector = OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D3;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D3 = resultSelector = (Func<TEntity, IEnumerable<OfacSystem.OfacStatus>, (TEntity, IEnumerable<OfacSystem.OfacStatus>)>) ([SpecialName] (ai, ofac) => (ai, ofac));
      }
      IEnumerable<(TEntity, IEnumerable<OfacSystem.OfacStatus>)> source2 = outer.GroupJoin<TEntity, OfacSystem.OfacStatus, (Guid, Guid?), (TEntity, IEnumerable<OfacSystem.OfacStatus>)>((IEnumerable<OfacSystem.OfacStatus>) status, outerKeySelector, innerKeySelector, resultSelector);
      System.Func<(TEntity, IEnumerable<OfacSystem.OfacStatus>), TEntity> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D4 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D4;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D4 = keySelector = (System.Func<(TEntity, IEnumerable<OfacSystem.OfacStatus>), TEntity>) ([SpecialName] (ai) => ai.OfacEntity);
      }
      System.Func<(TEntity, IEnumerable<OfacSystem.OfacStatus>), OfacSystem.OfacStatus> elementSelector;
      // ISSUE: reference to a compiler-generated field
      if (OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D5 != null)
      {
        // ISSUE: reference to a compiler-generated field
        elementSelector = OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D5;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        OfacSystem._Closure\u0024__69<TEntity>.\u0024I69\u002D5 = elementSelector = (System.Func<(TEntity, IEnumerable<OfacSystem.OfacStatus>), OfacSystem.OfacStatus>) ([SpecialName] (ai) => ai.OfacStatuses.SingleOrDefault<OfacSystem.OfacStatus>());
      }
      entityDictionary = source2.ToDictionary<(TEntity, IEnumerable<OfacSystem.OfacStatus>), TEntity, OfacSystem.OfacStatus>(keySelector, elementSelector);
      goto label_22;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "Entities", (object) entities);
      ErrorHandler.WriteLog(ex2);
      ProjectData.ClearProjectError();
    }
    entityDictionary = new Dictionary<TEntity, OfacSystem.OfacStatus>();
label_22:
    return entityDictionary;
  }

  protected virtual List<OfacSystem.OfacStatus> EntityTableToStatus(
    DataTable hitTable,
    bool excludeInvalid = false)
  {
    List<OfacSystem.OfacStatus> status = new List<OfacSystem.OfacStatus>();
    try
    {
      foreach (DataRow row in hitTable.Rows)
      {
        if (!row.IsNull("EntityGuid"))
        {
          OfacSystem.OfacStatus objectAs = ObjectFactory.Instance.CreateObjectAs<OfacSystem.OfacStatus>((object) row);
          if (!excludeInvalid || (objectAs != null ? (objectAs.IsValid ? 1 : 0) : 0) != 0)
            status.Add(objectAs);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return status;
  }

  public event EventHandler<OfacSystem.OfacResult> OfacSearch;

  public event EventHandler<OfacClearContext> OfacCleared;

  public event EventHandler<OfacClearContext> OfacReinstated;

  public event EventHandler<OfacResetContext> OfacReset;

  protected void OnOfacSearch(OfacSystem.OfacResult result)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler<OfacSystem.OfacResult> ofacSearchEvent = this.OfacSearchEvent;
    if (ofacSearchEvent != null)
      ofacSearchEvent((object) null, result);
    Messaging.SendBroadcastMessage(BroadcastMessages.EntityOfacSearch, (object) result);
  }

  protected void OnOfacCleared(OfacClearContext clear)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler<OfacClearContext> ofacClearedEvent = this.OfacClearedEvent;
    if (ofacClearedEvent != null)
      ofacClearedEvent((object) null, clear);
    Messaging.SendBroadcastMessage(BroadcastMessages.EntityOfacClear, (object) clear);
  }

  protected void OnOfacReinstated(OfacClearContext clear)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler<OfacClearContext> ofacReinstatedEvent = this.OfacReinstatedEvent;
    if (ofacReinstatedEvent != null)
      ofacReinstatedEvent((object) null, clear);
    Messaging.SendBroadcastMessage(BroadcastMessages.EntityOfacReinstated, (object) clear);
  }

  protected void OnOfacReset(OfacResetContext reset)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler<OfacResetContext> ofacResetEvent = this.OfacResetEvent;
    if (ofacResetEvent != null)
      ofacResetEvent((object) null, reset);
    Messaging.SendBroadcastMessage(BroadcastMessages.EntityOfacReset, (object) reset);
  }

  [XmlRoot("Criteria")]
  public class OfacCriteria
  {
    public OfacCriteria()
    {
      this.FirstName = (string) null;
      this.LastName = (string) null;
      this.Address = (string) null;
      this.Address2 = (string) null;
      this.City = (string) null;
      this.State = (string) null;
      this.ZipCode = (string) null;
      this.IsoCountryCode = (string) null;
      this.DateOfBirth = (string) null;
      this.Data = new Dictionary<string, string>();
    }

    public OfacCriteria(IOfacEntity entity)
    {
      this.FirstName = (string) null;
      this.LastName = (string) null;
      this.Address = (string) null;
      this.Address2 = (string) null;
      this.City = (string) null;
      this.State = (string) null;
      this.ZipCode = (string) null;
      this.IsoCountryCode = (string) null;
      this.DateOfBirth = (string) null;
      this.Data = new Dictionary<string, string>();
      this.EntityGuid = entity.EntityGuid;
      this.ParentGuid = entity.ParentEntityGuid;
    }

    public OfacCriteria(IOfacSearchEntity entity)
      : this((IOfacEntity) entity)
    {
      this.EntityType = entity.EntityType;
      this.RecreateTypeName = entity.RecreateTypeName;
    }

    [XmlIgnore]
    public Guid EntityGuid { get; set; }

    [XmlIgnore]
    public Guid? ParentGuid { get; set; }

    public string EntityType { get; set; }

    public string RecreateTypeName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Address { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string IsoCountryCode { get; set; }

    public string DateOfBirth { get; set; }

    public Dictionary<string, string> Data { get; set; }

    public string PolicyName
    {
      get
      {
        return !string.IsNullOrEmpty(this.FirstName) ? $"{this.FirstName} {this.LastName}" : this.LastName;
      }
    }

    public bool ValidCriteria()
    {
      if (!this.EntityGuid.Equals(Guid.Empty))
      {
        Guid? parentGuid = this.ParentGuid;
        if (parentGuid.HasValue)
        {
          parentGuid = this.ParentGuid;
          if (parentGuid.Equals((object) Guid.Empty))
            goto label_5;
        }
        if (!string.IsNullOrEmpty(this.PolicyName))
          return !string.IsNullOrEmpty(this.EntityType);
      }
label_5:
      return false;
    }

    public string SerializeCriteria()
    {
      XName name = (XName) "Criteria";
      object[] objArray = new object[11]
      {
        (object) new XElement((XName) "PolicyName", (object) this.PolicyName),
        (object) new XElement((XName) "FirstName", (object) this.FirstName),
        (object) new XElement((XName) "LastName", (object) this.LastName),
        (object) new XElement((XName) "Address", (object) this.Address),
        (object) new XElement((XName) "Address2", (object) this.Address2),
        (object) new XElement((XName) "City", (object) this.City),
        (object) new XElement((XName) "State", (object) this.State),
        (object) new XElement((XName) "ZipCode", (object) this.ZipCode),
        (object) new XElement((XName) "IsoCountryCode", (object) this.IsoCountryCode),
        (object) new XElement((XName) "DateOfBirth", (object) this.DateOfBirth),
        null
      };
      Dictionary<string, string> data = this.Data;
      IEnumerable<XElement> xelements;
      if (data == null)
      {
        xelements = (IEnumerable<XElement>) null;
      }
      else
      {
        System.Func<KeyValuePair<string, string>, XElement> selector;
        // ISSUE: reference to a compiler-generated field
        if (OfacSystem.OfacCriteria._Closure\u0024__.\u0024I62\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = OfacSystem.OfacCriteria._Closure\u0024__.\u0024I62\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          OfacSystem.OfacCriteria._Closure\u0024__.\u0024I62\u002D0 = selector = (System.Func<KeyValuePair<string, string>, XElement>) ([SpecialName] (kvp) => new XElement((XName) $"Data.{kvp.Key}", (object) kvp.Value));
        }
        xelements = data.Select<KeyValuePair<string, string>, XElement>(selector);
      }
      objArray[10] = (object) xelements;
      XElement xelement1 = new XElement(name, objArray);
      try
      {
        foreach (XElement xelement2 in xelement1.Descendants().ToList<XElement>())
        {
          if (string.IsNullOrEmpty(xelement2.Value))
            xelement2.Remove();
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      return xelement1.ToString();
    }
  }

  public class OfacResult
  {
    public string OfacXml { get; set; }

    public string ReturnCode { get; set; }

    public string ReturnScore { get; set; }

    public string ErrorDescription { get; set; }

    public OfacSystem.OfacCriteria SearchCriteria { get; set; }

    public int OfacTypeID { get; set; }

    public bool OfacHit { get; set; }

    public int OfacScore
    {
      get
      {
        int result = -1;
        return !int.TryParse(this.ReturnScore, out result) ? -1 : result;
      }
    }
  }

  public class OfacStatus
  {
    public OfacStatus(DataRow dr)
    {
      this.EntityGuid = (dr != null ? (dr.IsNull(nameof (EntityGuid)) ? 1 : 0) : 1) == 0 ? dr.Field<Guid>("EntityGUID") : throw new InvalidOperationException("Specified entity does not contain OFAC data.");
      this.ParentEntityGuid = dr.Field<Guid?>("ParentEntityGUID");
      this.EntityType = dr.Field<string>(nameof (EntityType));
      this.OfacTypeID = dr.Field<int>(nameof (OfacTypeID));
      this.IsOfacCleared = dr.Field<bool>(nameof (OFACCleared));
      this.LogDate = dr.Field<DateTime>(nameof (LogDate));
      this.ReturnScore = dr.Field<int>(nameof (ReturnScore));
      this.ReturnCode = dr.Field<string>(nameof (ReturnCode));
      this.OfacXml = dr.Field<string>(nameof (OfacXml));
      this.HitDate = dr.Field<DateTime?>(nameof (HitDate));
      this.HitScore = dr.Field<int?>(nameof (HitScore));
      this.ClearDate = dr.Field<DateTime?>(nameof (ClearDate));
      this.ClearByUserGuid = dr.Field<Guid?>(nameof (ClearByUserGuid));
      this.ClearReason = dr.Field<string>(nameof (ClearReason));
      this.ClearReasonID = dr.Field<int?>(nameof (ClearReasonID));
    }

    public OfacStatus(
      Guid entityGuid,
      Guid? parentEntityGuid,
      string entityType,
      int ofacType,
      bool ofacClear,
      DateTime logDate,
      int score,
      string code,
      string xml,
      DateTime? hitDate,
      int? hitScore,
      DateTime? clearDate,
      Guid? clearUser,
      string clearReason,
      int? reasonId)
    {
      this.EntityGuid = entityGuid;
      this.ParentEntityGuid = parentEntityGuid;
      this.EntityType = entityType;
      this.OfacTypeID = ofacType;
      this.IsOfacCleared = ofacClear;
      this.LogDate = logDate;
      this.ReturnScore = score;
      this.ReturnCode = code;
      this.OfacXml = xml;
      this.HitDate = hitDate;
      this.HitScore = hitScore;
      this.ClearDate = clearDate;
      this.ClearByUserGuid = clearUser;
      this.ClearReason = clearReason;
      this.ClearReasonID = reasonId;
    }

    public Guid EntityGuid { get; }

    public Guid? ParentEntityGuid { get; }

    public string EntityType { get; }

    public int OfacTypeID { get; }

    public bool IsOfacCleared { get; }

    public DateTime LogDate { get; }

    public int ReturnScore { get; }

    public string ReturnCode { get; }

    public string OfacXml { get; }

    public DateTime? HitDate { get; }

    public int? HitScore { get; }

    public DateTime? ClearDate { get; }

    public Guid? ClearByUserGuid { get; }

    public string ClearReason { get; }

    public int? ClearReasonID { get; }

    public bool? ClearOverride { get; set; }

    public object DataContext
    {
      get => this._DataContext;
      set => this._DataContext = RuntimeHelpers.GetObjectValue(value);
    }

    public virtual bool OFACCleared
    {
      get
      {
        return !this.ClearOverride.HasValue ? OfacSystem.Instance.GetSetting(this.OfacTypeID).IsOfacSearchCleared(this) : this.ClearOverride.Value;
      }
    }

    public virtual bool IsHit
    {
      get => OfacSystem.Instance.GetSetting(this.OfacTypeID).IsOfacSearchHit(this);
    }

    public virtual bool IsValid
    {
      get
      {
        IOfacSetting setting = OfacSystem.Instance.GetSetting(this.OfacTypeID);
        return setting.IsValid && setting.IsOfacSearchValid(this);
      }
    }

    public virtual string HitMessage
    {
      get => OfacSystem.Instance.GetSetting(this.OfacTypeID).OfacHitMessage(this);
    }

    public DataSet GetOfacDataset
    {
      get => OfacSystem.Instance.GetSetting(this.OfacTypeID).GetOfacDataset(this);
    }

    public OfacSystem.OfacResult SearchAgain()
    {
      return OfacSystem.Instance.SearchByEntityGuid(this.EntityType, this.EntityGuid);
    }
  }
}
