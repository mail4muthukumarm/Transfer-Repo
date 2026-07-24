// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.Serialization.Preferences
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.Serialization;

public class Preferences : IPreferenceManager
{
  private static readonly List<string> _localPreferenceHash = new List<string>();
  private static dsLocalPreferences _dsLocalPreferences;
  private const string localPreferencesFileName = "IMSLocalPreferences.mga";
  private const string localPreferencesApplicationFolderName = "IMSLocalPreferences.mga";
  private static Dictionary<string, object> _assemblyReferenceHash;
  private static Dictionary<string, object> _remotePreferencesCache;

  public static void ResetPreference(string preferenceName)
  {
    if (!Preferences.PreferenceDefaultsHash.ContainsKey(preferenceName))
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(Preferences.PreferenceDefaultsHash[preferenceName]);
    Preferences.SetPreference(preferenceName, RuntimeHelpers.GetObjectValue(objectValue));
  }

  public static void ResetPreferences()
  {
    Preferences.LocalPreferencesSet.Clear();
    Preferences._dsLocalPreferences = (dsLocalPreferences) null;
    Preferences.RemotePreferencesCache.Clear();
    Preferences._remotePreferencesCache = (Dictionary<string, object>) null;
    Database.Instance.QueryText.PerformNonQuery("DELETE FROM tblPreferences WHERE UserGUID = @UserGUID", (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID);
  }

  public static void BeginCompactPreferences()
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(Preferences.CompactPreferencesThread));
  }

  private static void CompactPreferencesThread(object state)
  {
    DataTable dataTable = Database.Instance.QueryText.PerformTableQuery("SELECT  PreferenceName FROM tblPreferences WHERE UserGUID = @UserGUID", (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (!Preferences.PreferenceDefaultsHash.ContainsKey(Conversions.ToString(row["PreferenceName"])))
          Database.Instance.QueryText.PerformNonQuery("DELETE FROM tblPreferences WHERE UserGUID = @UserGUID AND PreferenceName = @PreferenceName", (object) "@PreferenceName", (object) Conversions.ToString(row["PreferenceName"]), (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void SetPreference(string name, object value)
  {
    Preferences.InternalSavePreference(name, RuntimeHelpers.GetObjectValue(value), Preferences.IsPreferenceLocal(name));
  }

  public static void SetPreference(string name, int value)
  {
    Preferences.InternalSavePreference(name, (object) value, Preferences.IsPreferenceLocal(name));
  }

  public static void SetPreference(string name, long value)
  {
    Preferences.InternalSavePreference(name, (object) value, Preferences.IsPreferenceLocal(name));
  }

  public static void SetPreference(string name, float value)
  {
    Preferences.InternalSavePreference(name, (object) value, Preferences.IsPreferenceLocal(name));
  }

  public static void SetPreference(string name, double value)
  {
    Preferences.InternalSavePreference(name, (object) value, Preferences.IsPreferenceLocal(name));
  }

  public static void SetPreference(string name, Decimal value)
  {
    Preferences.InternalSavePreference(name, (object) value, Preferences.IsPreferenceLocal(name));
  }

  public static void SetPreference(string name, string value)
  {
    Preferences.InternalSavePreference(name, (object) value, Preferences.IsPreferenceLocal(name));
  }

  public static void SetPreference(string name, bool value)
  {
    Preferences.InternalSavePreference(name, (object) value, Preferences.IsPreferenceLocal(name));
  }

  [SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "tbl")]
  private static bool IsPreferenceLocal(string preferenceName)
  {
    Dictionary<string, object> preferenceDefaultsHash = Preferences.PreferenceDefaultsHash;
    return Preferences._localPreferenceHash.Contains(preferenceName);
  }

  public static int GetPreferenceInt(string name)
  {
    return Conversions.ToInteger(Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name)));
  }

  public static long GetPreferenceLong(string name)
  {
    return Conversions.ToLong(Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name)));
  }

  public static float GetPreferenceSingle(string name)
  {
    return Conversions.ToSingle(Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name)));
  }

  public static double GetPreferenceDouble(string name)
  {
    return Conversions.ToDouble(Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name)));
  }

  public static Decimal GetPreferenceDecimal(string name)
  {
    return Conversions.ToDecimal(Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name)));
  }

  public static string GetPreferenceString(string name)
  {
    return Conversions.ToString(Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name)));
  }

  public static bool GetPreferenceBool(string name)
  {
    return Conversions.ToBoolean(Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name)));
  }

  public static object GetPreference(string name)
  {
    return Preferences.InternalGetPreference(name, Preferences.IsPreferenceLocal(name));
  }

  [SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "db")]
  private static bool IsDBAvailable
  {
    get
    {
      bool isDbAvailable;
      try
      {
        Database instance = Database.Instance;
        isDbAvailable = true;
      }
      catch (DatabaseException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        isDbAvailable = false;
        ProjectData.ClearProjectError();
      }
      return isDbAvailable;
    }
  }

  private static void InternalSavePreference(string name, object value, bool useLocalStorage)
  {
    if (!useLocalStorage)
      Preferences.InternalSavePreferenceRemote(name, RuntimeHelpers.GetObjectValue(value));
    else
      Preferences.InternalSavePreferenceLocally(name, RuntimeHelpers.GetObjectValue(value));
  }

  private static object InternalGetPreference(string name, bool useLocalStorage)
  {
    return useLocalStorage ? Preferences.InternalGetPreferenceLocally(name) : Preferences.InternalGetPreferenceRemote(name);
  }

  private static void InternalSavePreferenceLocally(string name, object value)
  {
    if (!Preferences.PreferenceDefaultsHash.ContainsKey(name))
      throw new InvalidOperationException("Value not found for this item");
    if (RuntimeHelpers.GetObjectValue(Preferences.PreferenceDefaultsHash[name]).Equals(RuntimeHelpers.GetObjectValue(value)))
    {
      DataRow[] dataRowArray = Preferences.LocalPreferencesSet.LocalPreferences.Select($"PreferenceName = '{name}'");
      int index = 0;
      while (index < dataRowArray.Length)
      {
        Preferences.LocalPreferencesSet.LocalPreferences.RemoveLocalPreferencesRow((dsLocalPreferences.LocalPreferencesRow) dataRowArray[index]);
        checked { ++index; }
      }
      Preferences.LocalPreferencesSet.LocalPreferences.AcceptChanges();
      Preferences.SaveLocalPreferences();
    }
    else
    {
      DataRow[] dataRowArray = Preferences.LocalPreferencesSet.LocalPreferences.Select($"PreferenceName = '{name}'");
      if (dataRowArray.Length == 0)
      {
        Preferences.LocalPreferencesSet.LocalPreferences.AddLocalPreferencesRow(name, value.ToString(), value.GetType().ToString());
      }
      else
      {
        dsLocalPreferences.LocalPreferencesRow localPreferencesRow = (dsLocalPreferences.LocalPreferencesRow) dataRowArray[0];
        localPreferencesRow.PreferenceValue = value.ToString();
        localPreferencesRow.PreferenceType = value.GetType().ToString();
      }
      Preferences.LocalPreferencesSet.LocalPreferences.AcceptChanges();
      Preferences.SaveLocalPreferences();
    }
  }

  private static void InternalSavePreferenceRemote(string name, object value)
  {
    Preferences.VerifyRemoteAccess();
    bool flag = false;
    if (Preferences.RemotePreferencesCache.ContainsKey(name))
    {
      if (RuntimeHelpers.GetObjectValue(Preferences.RemotePreferencesCache[name]).Equals(RuntimeHelpers.GetObjectValue(value)))
        return;
      Preferences.RemotePreferencesCache.Remove(name);
      Preferences.RemotePreferencesCache.Add(name, RuntimeHelpers.GetObjectValue(value));
      flag = true;
    }
    else
    {
      if (!Preferences.PreferenceDefaultsHash.ContainsKey(name))
        throw new PreferenceException(MGASystems.IMS.NoteDocuments.SR.GetString("PREFERENCES_ATRRIBUTENOTDEFINEDERROR", (object) name));
      if (!RuntimeHelpers.GetObjectValue(Preferences.PreferenceDefaultsHash[name]).Equals(RuntimeHelpers.GetObjectValue(value)))
      {
        Preferences.RemotePreferencesCache.Add(name, RuntimeHelpers.GetObjectValue(value));
        flag = true;
      }
    }
    if (!flag)
      return;
    Database.Instance.QuerySP.PerformNonQuery("dbo.SetPreference", (object) "@PreferenceName", (object) name, (object) "@PreferenceValue", (object) value.ToString(), (object) "@PreferenceType", (object) value.GetType().ToString(), (object) "@UserID", (object) MGASystems.IMS.NoteDocuments.Common.UserID);
  }

  private static object InternalGetPreferenceRemote(string name)
  {
    object preferenceRemote;
    if (Preferences.RemotePreferencesCache.ContainsKey(name))
    {
      preferenceRemote = Preferences.RemotePreferencesCache[name];
    }
    else
    {
      Preferences.VerifyRemoteAccess();
      DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("dbo.GetPreference", (object) "@PreferenceName", (object) name, (object) "@UserID", (object) MGASystems.IMS.NoteDocuments.Common.UserID);
      if (dataTable.Rows.Count == 0)
      {
        object obj = Preferences.PreferenceDefaultsHash.ContainsKey(name) ? RuntimeHelpers.GetObjectValue(Preferences.PreferenceDefaultsHash[name]) : throw new PreferenceException(MGASystems.IMS.NoteDocuments.SR.GetString("PREFERENCES_ATRRIBUTENOTDEFINEDERROR", (object) name));
        Preferences.RemotePreferencesCache.Add(name, RuntimeHelpers.GetObjectValue(obj));
        preferenceRemote = obj;
      }
      else
      {
        DataRow row = dataTable.Rows[0];
        string str = (string) row["PreferenceValue"];
        string typeName = (string) row["PreferenceType"];
        if (!Preferences.RemotePreferencesCache.ContainsKey(name))
        {
          object objectValue = RuntimeHelpers.GetObjectValue(Preferences.TranslatePreferenceValueStringToObject(str, typeName));
          Preferences.RemotePreferencesCache.Add(name, RuntimeHelpers.GetObjectValue(objectValue));
        }
        preferenceRemote = Preferences.TranslatePreferenceValueStringToObject(str, typeName);
      }
    }
    return preferenceRemote;
  }

  internal static DataTable CurrentPreferencesTable
  {
    get
    {
      DataTable preferencesTable = new DataTable();
      preferencesTable.Columns.Add("Preference", typeof (string));
      preferencesTable.Columns.Add("Status", typeof (string));
      preferencesTable.Columns.Add("Type", typeof (string));
      preferencesTable.Columns.Add("Value", typeof (string));
      preferencesTable.Columns.Add("Default", typeof (string));
      preferencesTable.Columns.Add("Local", typeof (string));
      preferencesTable.BeginLoadData();
      try
      {
        foreach (KeyValuePair<string, object> keyValuePair in Preferences.PreferenceDefaultsHash)
        {
          string key = keyValuePair.Key;
          object objectValue = RuntimeHelpers.GetObjectValue(keyValuePair.Value);
          string name = keyValuePair.Value.GetType().Name;
          preferencesTable.Rows.Add((object) key, (object) "default", (object) name, (object) objectValue.ToString(), (object) objectValue.ToString());
        }
      }
      finally
      {
        Dictionary<string, object>.Enumerator enumerator;
        enumerator.Dispose();
      }
      preferencesTable.EndLoadData();
      if (MGASystems.IMS.NoteDocuments.Common.UserIsLoggedIn)
      {
        DataTable dataTable = Database.Instance.QueryText.PerformTableQuery("SELECT  PreferenceName, PreferenceValue, PreferenceType FROM tblPreferences WHERE UserGUID = @UserGUID", (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID);
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            string str = Conversions.ToString(row["PreferenceName"]);
            string typeName = Conversions.ToString(row["PreferenceType"]);
            string Right = Conversions.ToString(row["PreferenceValue"]);
            DataRow[] dataRowArray = preferencesTable.Select($"Preference = '{str}'");
            if (dataRowArray != null && dataRowArray.Length == 1)
            {
              DataRow dataRow = dataRowArray[0];
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(dataRow["Value"]), Right, false) != 0)
              {
                dataRow["Value"] = RuntimeHelpers.GetObjectValue(Preferences.TranslatePreferenceValueStringToObject(Right, typeName));
                dataRow["Status"] = (object) "user set";
              }
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      try
      {
        foreach (dsLocalPreferences.LocalPreferencesRow localPreference in (TypedTableBase<dsLocalPreferences.LocalPreferencesRow>) Preferences.LocalPreferencesSet.LocalPreferences)
        {
          DataRow[] dataRowArray = preferencesTable.Select($"Preference = '{localPreference.PreferenceName}'");
          if (dataRowArray != null && dataRowArray.Length == 1)
          {
            DataRow dataRow = dataRowArray[0];
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(dataRow["Value"]), localPreference.PreferenceValue, false) != 0)
            {
              dataRow["Value"] = RuntimeHelpers.GetObjectValue(Preferences.TranslatePreferenceValueStringToObject(localPreference.PreferenceValue, localPreference.PreferenceType));
              dataRow["Status"] = (object) "user set";
            }
          }
        }
      }
      finally
      {
        IEnumerator<dsLocalPreferences.LocalPreferencesRow> enumerator;
        enumerator?.Dispose();
      }
      preferencesTable.DefaultView.Sort = "Preference ASC";
      return preferencesTable;
    }
  }

  internal static object TranslatePreferenceValueStringToObject(string value, string typeName)
  {
    string str = typeName;
    object obj;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 347085918:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Boolean", false) == 0)
        {
          obj = (object) Conversions.ToBoolean(value);
          break;
        }
        goto default;
      case 848225627:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Double", false) == 0)
        {
          obj = (object) Conversions.ToDouble(value);
          break;
        }
        goto default;
      case 1741144581:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Decimal", false) == 0)
        {
          obj = (object) Conversions.ToDecimal(value);
          break;
        }
        goto default;
      case 1764058053:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Int64", false) == 0)
        {
          obj = (object) Conversions.ToLong(value);
          break;
        }
        goto default;
      case 2185383742:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Single", false) == 0)
        {
          obj = (object) Conversions.ToSingle(value);
          break;
        }
        goto default;
      case 4180476474:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Int32", false) == 0)
        {
          obj = (object) Conversions.ToInteger(value);
          break;
        }
        goto default;
      case 4201364391:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.String", false) == 0)
        {
          obj = (object) value;
          break;
        }
        goto default;
      default:
        obj = (object) null;
        break;
    }
    return obj;
  }

  private static Dictionary<string, object> PreferenceDefaultsHash
  {
    get
    {
      if (Preferences._assemblyReferenceHash == null)
      {
        Preferences._assemblyReferenceHash = new Dictionary<string, object>();
        Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new PreferenceAttribute());
        int index1 = 0;
        while (index1 < typeArray.Length)
        {
          object[] customAttributes = typeArray[index1].GetCustomAttributes(typeof (PreferenceAttribute), false);
          if (customAttributes != null)
          {
            object[] objArray = customAttributes;
            int index2 = 0;
            while (index2 < objArray.Length)
            {
              PreferenceAttribute preferenceAttribute = (PreferenceAttribute) objArray[index2];
              Preferences._assemblyReferenceHash.Add(preferenceAttribute.Name, RuntimeHelpers.GetObjectValue(preferenceAttribute.DefaultValue));
              if (preferenceAttribute.Local)
                Preferences._localPreferenceHash.Add(preferenceAttribute.Name);
              checked { ++index2; }
            }
          }
          checked { ++index1; }
        }
      }
      return Preferences._assemblyReferenceHash;
    }
  }

  public static void AddRuntimeDefinedPreferenceDefault(string name, object defaultValue)
  {
    if (Preferences.IsPreferenceDefaultDefined(name))
      return;
    Preferences.PreferenceDefaultsHash.Add(name, RuntimeHelpers.GetObjectValue(defaultValue));
  }

  public static bool IsPreferenceDefaultDefined(string name)
  {
    return Preferences.PreferenceDefaultsHash.ContainsKey(name);
  }

  private static Dictionary<string, object> RemotePreferencesCache
  {
    get
    {
      if (Preferences._remotePreferencesCache == null)
        Preferences._remotePreferencesCache = new Dictionary<string, object>();
      return Preferences._remotePreferencesCache;
    }
  }

  private static object InternalGetPreferenceLocally(string name)
  {
    DataRow[] dataRowArray = Preferences.LocalPreferencesSet.LocalPreferences.Select($"PreferenceName = '{name}'");
    object preferenceLocally;
    if (dataRowArray.Length == 0)
    {
      preferenceLocally = Preferences.PreferenceDefaultsHash.ContainsKey(name) ? Preferences.PreferenceDefaultsHash[name] : throw new PreferenceException(MGASystems.IMS.NoteDocuments.SR.GetString("PREFERENCES_ATRRIBUTENOTDEFINEDERROR", (object) name));
    }
    else
    {
      dsLocalPreferences.LocalPreferencesRow localPreferencesRow = (dsLocalPreferences.LocalPreferencesRow) dataRowArray[0];
      preferenceLocally = Preferences.TranslatePreferenceValueStringToObject(localPreferencesRow.PreferenceValue, localPreferencesRow.PreferenceType);
    }
    return preferenceLocally;
  }

  private static dsLocalPreferences LocalPreferencesSet
  {
    get
    {
      if (Preferences._dsLocalPreferences == null)
      {
        Preferences._dsLocalPreferences = new dsLocalPreferences();
        Preferences.LoadLocalPreferences();
      }
      return Preferences._dsLocalPreferences;
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  private static void LoadLocalPreferences()
  {
    if (!File.Exists(Preferences.LocalPreferencesPath))
      return;
    try
    {
      int num = (int) Preferences.LocalPreferencesSet.ReadXml(Preferences.LocalPreferencesPath);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private static void SaveLocalPreferences()
  {
    if (File.Exists(Preferences.LocalPreferencesPath))
      File.Delete(Preferences.LocalPreferencesPath);
    Preferences.LocalPreferencesSet.WriteXml(Preferences.LocalPreferencesPath);
  }

  public override int GetHashCode() => base.GetHashCode();

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool Equals(object objA, object objB)
  {
    return object.Equals(RuntimeHelpers.GetObjectValue(objA), RuntimeHelpers.GetObjectValue(objB));
  }

  [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool ReferenceEquals(object objA, object objB)
  {
    return object.Equals(RuntimeHelpers.GetObjectValue(objA), RuntimeHelpers.GetObjectValue(objB));
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public new bool Equals(object obj) => base.Equals(RuntimeHelpers.GetObjectValue(obj));

  public static string LocalPreferencesPath
  {
    get
    {
      string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{"IMSLocalPreferences.mga"}\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      return $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{"IMSLocalPreferences.mga"}\\{"IMSLocalPreferences.mga"}";
    }
  }

  private static void VerifyRemoteAccess()
  {
    if (!Preferences.IsDBAvailable)
      throw new PreferenceException(MGASystems.IMS.NoteDocuments.SR.GetString("PREFERENCES_REMOTEDBNOTFOUND"));
  }

  public bool GetPreferenceBoolInternal(string preference)
  {
    return Preferences.GetPreferenceBool(preference);
  }

  public int GetPreferenceIntInternal(string preference)
  {
    return Preferences.GetPreferenceInt(preference);
  }
}
