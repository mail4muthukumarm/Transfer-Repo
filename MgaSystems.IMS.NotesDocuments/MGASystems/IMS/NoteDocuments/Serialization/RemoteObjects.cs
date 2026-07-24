// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.Serialization.RemoteObjects
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.Serialization;

public class RemoteObjects : IRemoteObjectManager
{
  private static Dictionary<string, object> _objects = new Dictionary<string, object>();
  private static Assembly _assembly;

  public static void SetObject(string settingName, object settingValue)
  {
    if (RemoteObjects._objects.ContainsKey(settingName))
      RemoteObjects._objects.Remove(settingName);
    RemoteObjects._objects.Add(settingName, RuntimeHelpers.GetObjectValue(settingValue));
    settingValue = RuntimeHelpers.GetObjectValue(RemoteObjects.ConvertToBinary(ref settingName, RuntimeHelpers.GetObjectValue(settingValue)));
    Database.Instance.QuerySP.PerformNonQuery("dbo.SetSetting", (object) "@SettingValue", settingValue, (object) "@SettingKey", (object) settingName, (object) "@UserID", (object) MGASystems.IMS.NoteDocuments.Common.UserID);
  }

  public static object GetObject(string settingName, Assembly deserializeAssembly)
  {
    return RemoteObjects.GetObject(settingName, (object) null, deserializeAssembly);
  }

  public static object GetObject(
    string settingName,
    object defaultValue,
    Assembly deserializeAssembly)
  {
    object obj1;
    if (RemoteObjects._objects.ContainsKey(settingName))
    {
      obj1 = RemoteObjects._objects[settingName];
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(Database.Instance.QuerySP.PerformScalarQuery("GetSetting", (object) "@userID", (object) MGASystems.IMS.NoteDocuments.Common.UserID, (object) "@settingKey", (object) settingName));
      if (Database.IsValueNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        obj1 = defaultValue;
      }
      else
      {
        object obj2 = (object) deserializeAssembly != null ? RuntimeHelpers.GetObjectValue(RemoteObjects.ConvertFromBinary(settingName, RuntimeHelpers.GetObjectValue(objectValue), deserializeAssembly)) : RuntimeHelpers.GetObjectValue(RemoteObjects.ConvertFromBinary(settingName, RuntimeHelpers.GetObjectValue(objectValue)));
        if (!RemoteObjects._objects.ContainsKey(settingName))
          RemoteObjects._objects.Add(settingName, RuntimeHelpers.GetObjectValue(obj2));
        obj1 = obj2;
      }
    }
    return obj1;
  }

  public static object GetObject(string settingName, object defaultValue)
  {
    return RemoteObjects.GetObject(settingName, RuntimeHelpers.GetObjectValue(defaultValue), (Assembly) null);
  }

  public static object GetObject(string settingName)
  {
    return RemoteObjects.GetObject(settingName, (object) null, (Assembly) null);
  }

  public static void RemoveObject(string settingName)
  {
    if (RemoteObjects._objects.ContainsKey(settingName))
      RemoteObjects._objects.Remove(settingName);
    Database.Instance.QuerySP.PerformNonQuery("DeleteSetting", (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID, (object) "@SettingKey", (object) settingName);
  }

  private static Assembly AppDomain_AssemblyResolve(object sender, ResolveEventArgs e)
  {
    return RemoteObjects._assembly;
  }

  private static object ConvertFromBinary(string name, object result)
  {
    return RemoteObjects.ConvertFromBinary(name, RuntimeHelpers.GetObjectValue(result), (Assembly) null);
  }

  private static object ConvertFromBinary(
    string name,
    object result,
    Assembly assemblyDeserializer)
  {
    object obj;
    try
    {
      new SecurityPermission(SecurityPermissionFlag.ControlAppDomain).Demand();
      obj = RemoteObjects.InternalConvertFromBinary(name, RuntimeHelpers.GetObjectValue(result), assemblyDeserializer);
    }
    catch (SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      obj = (object) null;
      ProjectData.ClearProjectError();
    }
    return obj;
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  private static object InternalConvertFromBinary(
    string name,
    object result,
    Assembly assemblyDeserializer)
  {
    byte[] buffer = result as byte[];
    object obj;
    if (!name.Contains("_NATIVEBYTEARRAY"))
    {
      using (MemoryStream serializationStream1 = new MemoryStream(buffer))
      {
        try
        {
          obj = new BinaryFormatter().Deserialize((Stream) serializationStream1);
          goto label_20;
        }
        catch (SerializationException ex1)
        {
          ProjectData.SetProjectError((Exception) ex1);
          if ((object) assemblyDeserializer != null)
          {
            try
            {
              RemoteObjects._assembly = assemblyDeserializer;
              if ((object) RemoteObjects._assembly != null)
              {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (MemoryStream serializationStream2 = new MemoryStream(buffer))
                {
                  binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
                  AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(RemoteObjects.AppDomain_AssemblyResolve);
                  obj = binaryFormatter.Deserialize((Stream) serializationStream2);
                  ProjectData.ClearProjectError();
                  goto label_20;
                }
              }
            }
            catch (Exception ex2)
            {
              ProjectData.SetProjectError(ex2);
              Database.Instance.QuerySP.PerformNonQuery("DeleteSetting", (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID, (object) "@SettingKey", (object) name);
              ProjectData.ClearProjectError();
            }
            finally
            {
              if ((object) RemoteObjects._assembly != null)
              {
                AppDomain.CurrentDomain.AssemblyResolve -= new ResolveEventHandler(RemoteObjects.AppDomain_AssemblyResolve);
                RemoteObjects._assembly = (Assembly) null;
              }
            }
            ProjectData.ClearProjectError();
          }
          else
          {
            Database.Instance.QuerySP.PerformNonQuery("DeleteSetting", (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID, (object) "@SettingKey", (object) name);
            obj = (object) null;
            ProjectData.ClearProjectError();
            goto label_20;
          }
        }
      }
    }
    obj = (object) null;
label_20:
    return obj;
  }

  private static object ConvertToBinary(ref string name, object result)
  {
    object binary;
    if (!(result is byte[]))
    {
      MemoryStream serializationStream = new MemoryStream();
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      try
      {
        if (result != null)
          binaryFormatter.Serialize((Stream) serializationStream, RuntimeHelpers.GetObjectValue(result));
        binary = (object) serializationStream.ToArray();
      }
      finally
      {
        serializationStream.Close();
      }
    }
    else
    {
      name = $"{name}_NATIVEBYTEARRAY";
      binary = result;
    }
    return binary;
  }

  object IRemoteObjectManager.GetObjectInternal(string preference)
  {
    return RemoteObjects.GetObject(preference);
  }

  object IRemoteObjectManager.GetObjectInternal(string preference, object defaultValue)
  {
    return RemoteObjects.GetObject(preference, RuntimeHelpers.GetObjectValue(defaultValue));
  }

  void IRemoteObjectManager.RemoveObjectInternal(string preference)
  {
    RemoteObjects.RemoveObject(preference);
  }

  void IRemoteObjectManager.SetObjectInternal(string preference, object obj)
  {
    RemoteObjects.SetObject(preference, RuntimeHelpers.GetObjectValue(obj));
  }

  public void BeginRemoveObject(string preference)
  {
    if (RemoteObjects._objects.ContainsKey(preference))
      RemoteObjects._objects.Remove(preference);
    Database.Instance.QueryMultithreadedSP.PerformNonQuery("DeleteSetting", (object) "@UserGUID", (object) MGASystems.IMS.NoteDocuments.Common.UserGUID, (object) "@SettingKey", (object) preference);
  }

  public void BeginSetObject(string preference, object obj)
  {
    if (RemoteObjects._objects.ContainsKey(preference))
      RemoteObjects._objects.Remove(preference);
    RemoteObjects._objects.Add(preference, RuntimeHelpers.GetObjectValue(obj));
    obj = RuntimeHelpers.GetObjectValue(RemoteObjects.ConvertToBinary(ref preference, RuntimeHelpers.GetObjectValue(obj)));
    Database.Instance.QueryMultithreadedSP.PerformNonQuery("dbo.SetSetting", (object) "@SettingValue", obj, (object) "@SettingKey", (object) preference, (object) "@UserID", (object) MGASystems.IMS.NoteDocuments.Common.UserID);
  }
}
