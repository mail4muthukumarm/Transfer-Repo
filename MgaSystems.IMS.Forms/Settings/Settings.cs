// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Settings.Settings
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Forms.Settings;

public sealed class Settings
{
  private static MGASystems.IMS.Forms.Settings.Settings _settings;
  private Dictionary<string, object> _hashedSettings;
  private Hashtable _newKeyTable;
  private Hashtable _updateKeyTable;
  private Assembly _assembly;

  public static MGASystems.IMS.Forms.Settings.Settings Instance
  {
    get
    {
      if (MGASystems.IMS.Forms.Settings.Settings._settings == null)
        MGASystems.IMS.Forms.Settings.Settings._settings = new MGASystems.IMS.Forms.Settings.Settings();
      return MGASystems.IMS.Forms.Settings.Settings._settings;
    }
  }

  protected Settings()
  {
  }

  private Dictionary<string, object> HashedSettings
  {
    get
    {
      if (this._hashedSettings == null)
        this._hashedSettings = new Dictionary<string, object>();
      return this._hashedSettings;
    }
  }

  public void SavePrinterSetting(string key, PrinterSettings ps)
  {
    Hashtable hashtable = new Hashtable();
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    PropertyInfo[] properties = typeof (PrinterSettings).GetProperties(BindingFlags.Instance | BindingFlags.Public);
    int index = 0;
    while (index < properties.Length)
    {
      PropertyInfo propertyInfo = properties[index];
      MemoryStream serializationStream = new MemoryStream();
      try
      {
        if (propertyInfo.CanWrite)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue((object) ps, (object[]) null));
          binaryFormatter.Serialize((Stream) serializationStream, RuntimeHelpers.GetObjectValue(objectValue));
          hashtable.Add((object) propertyInfo.Name, RuntimeHelpers.GetObjectValue(objectValue));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        serializationStream.Close();
      }
      checked { ++index; }
    }
    this.InternalMainSaveSetting(key, (object) hashtable);
  }

  [Obsolete("Please use MGASystems.IMS.Forms.Serialization.Preferences instead.")]
  public void SaveSetting(string key, MemoryStream value)
  {
    if (value == null)
      throw new ArgumentNullException(nameof (value));
    this.InternalMainSaveSetting(key, (object) value.ToArray());
  }

  [Obsolete("Please use MGASystems.IMS.Forms.Serialization.Preferences instead.")]
  public void SaveSetting(string key, object value)
  {
    this.InternalMainSaveSetting(key, RuntimeHelpers.GetObjectValue(value));
  }

  [Obsolete("Please use MGASystems.IMS.Forms.Serialization.Preferences instead.")]
  public void SaveSetting(string key, byte[] value)
  {
    this.InternalMainSaveSetting(key, (object) value);
  }

  private void InternalMainSaveSetting(string key, object value)
  {
    if (this.HashedSettings.ContainsKey(key))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.HashedSettings[key]);
      if (objectValue != null && !objectValue.GetType().Equals(value.GetType()))
        return;
      this.InternalSaveSetting(key, RuntimeHelpers.GetObjectValue(value));
    }
    else
    {
      this.InternalLoadSetting(key);
      this.InternalSaveSetting(key, RuntimeHelpers.GetObjectValue(value));
    }
  }

  private void InternalSaveSetting(string key, object value)
  {
    if (!this.InternalHasSetting(key))
    {
      this.NewKeyTable.Add((object) key, (object) null);
      this.HashedSettings.Add(key, RuntimeHelpers.GetObjectValue(value));
    }
    else
    {
      if (RuntimeHelpers.GetObjectValue(this.HashedSettings[key]) == null)
        this.NewKeyTable.Add((object) key, (object) null);
      else if (!this.NewKeyTable.ContainsKey((object) key) && !this.UpdateKeyTable.ContainsKey((object) key))
        this.UpdateKeyTable.Add((object) key, (object) null);
      this.HashedSettings[key] = RuntimeHelpers.GetObjectValue(value);
    }
  }

  private Hashtable NewKeyTable
  {
    get
    {
      if (this._newKeyTable == null)
        this._newKeyTable = new Hashtable();
      return this._newKeyTable;
    }
  }

  private Hashtable UpdateKeyTable
  {
    get
    {
      if (this._updateKeyTable == null)
        this._updateKeyTable = new Hashtable();
      return this._updateKeyTable;
    }
  }

  [Obsolete("Please use MGASystems.IMS.Forms.Serialization.Preferences instead.")]
  public bool HasSetting(string key)
  {
    return RuntimeHelpers.GetObjectValue(this.InternalLoadSetting(key)) != null;
  }

  public void DeleteSetting(string key, bool forceDelete)
  {
    if (!forceDelete && !this.InternalHasSetting(key))
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserSettings WHERE UserGUID = @UG AND SettingKey = @S", new object[4]
    {
      (object) "@UG",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@S",
      (object) key
    });
    if (this.UpdateKeyTable.ContainsKey((object) key))
      this.UpdateKeyTable.Remove((object) key);
    if (this.NewKeyTable.ContainsKey((object) key))
      this.NewKeyTable.Remove((object) key);
    if (!this.HashedSettings.ContainsKey(key))
      return;
    this.HashedSettings.Remove(key);
  }

  protected bool InternalHasSetting(string key) => this.HashedSettings.ContainsKey(key);

  public PrinterSettings LoadPrinterSetting(string key)
  {
    PrinterSettings printerSettings1;
    if (RuntimeHelpers.GetObjectValue(this.InternalLoadSetting(key)) is Hashtable objectValue)
    {
      PrinterSettings printerSettings2 = new PrinterSettings();
      PropertyInfo[] properties = typeof (PrinterSettings).GetProperties(BindingFlags.Instance | BindingFlags.Public);
      int index = 0;
      while (index < properties.Length)
      {
        PropertyInfo propertyInfo = properties[index];
        if (objectValue.Contains((object) propertyInfo.Name) && propertyInfo.CanWrite)
          propertyInfo.SetValue((object) printerSettings2, RuntimeHelpers.GetObjectValue(objectValue[(object) propertyInfo.Name]), (object[]) null);
        checked { ++index; }
      }
      printerSettings1 = printerSettings2;
    }
    else
    {
      this.DeleteSetting(key, true);
      printerSettings1 = (PrinterSettings) null;
    }
    return printerSettings1;
  }

  [Obsolete("Please use MGASystems.IMS.Forms.Serialization.Preferences instead.")]
  public object LoadSetting(string key) => this.InternalLoadSetting(key, (Assembly) null);

  [Obsolete("Please use MGASystems.IMS.Forms.Serialization.Preferences instead.")]
  public object LoadSetting(string key, Assembly assemblyToDeserialize)
  {
    return this.InternalLoadSetting(key, assemblyToDeserialize);
  }

  public object InternalLoadSetting(string key) => this.InternalLoadSetting(key, (Assembly) null);

  public object InternalLoadSetting(string key, Assembly assemblyToDeserialize)
  {
    MGASystems.IMS.Forms.Settings.Settings settings = this;
    string key1 = key;
    Assembly assembly = assemblyToDeserialize;
    object obj1;
    if (CurrentUser.Instance.ConnectionString.Length == 0)
      obj1 = (object) null;
    else if (this.InternalHasSetting(key1))
    {
      obj1 = this.HashedSettings[key1];
    }
    else
    {
      try
      {
        DictionaryEntry dictionaryEntry;
        DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (obj, args) =>
        {
          if (args.Reader.Read())
          {
            closure_3 = true;
            if (Utility.IsNull(RuntimeHelpers.GetObjectValue(args.Reader[0])))
              return;
            dictionaryEntry = closure_2.ConvertBinaryEntryToValue(new DictionaryEntry((object) args.Reader.GetString(0), RuntimeHelpers.GetObjectValue(args.Reader.GetValue(1))), closure_0);
            if (dictionaryEntry.Key == null)
            {
              closure_2.DeleteSetting(args.Reader.GetString(0), false);
            }
            else
            {
              if (closure_2.HashedSettings.ContainsKey(dictionaryEntry.Key.ToString()))
                return;
              closure_2.HashedSettings.Add(dictionaryEntry.Key.ToString(), RuntimeHelpers.GetObjectValue(dictionaryEntry.Value));
            }
          }
          else
          {
            if (closure_2.HashedSettings.ContainsKey(closure_1))
              return;
            closure_2.HashedSettings.Add(closure_1, (object) null);
          }
        }), CommandType.Text, "SELECT  SettingKey, SettingValue FROM tblUserSettings WHERE UserGUID = @UG AND (SettingKey = @Key OR SettingKey = @Key_NATIVEBYTEARRAY)", new object[4]
        {
          (object) "@UG",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@Key",
          (object) closure_1
        });
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        obj1 = (object) null;
        ProjectData.ClearProjectError();
        goto label_8;
      }
      bool flag;
      obj1 = !flag ? (object) null : this.HashedSettings[closure_6];
    }
label_8:
    return obj1;
  }

  public void UpdateData()
  {
    new Thread(new ThreadStart(this.UpdateDataThread))
    {
      Name = "Save New Settings"
    }.Start();
  }

  private void UpdateDataThread()
  {
    if (this.UpdateKeyTable.Count <= 0 && this.NewKeyTable.Count <= 0)
      return;
    Hashtable binary = this.ConvertAllValuesToBinary();
    foreach (object obj in this.NewKeyTable)
    {
      DictionaryEntry dictionaryEntry = obj != null ? (DictionaryEntry) obj : new DictionaryEntry();
      DefaultDatabase.ExecuteNonQuery("dbo.SetSetting", new object[6]
      {
        (object) "@SettingValue",
        binary[RuntimeHelpers.GetObjectValue(dictionaryEntry.Key)],
        (object) "@SettingKey",
        dictionaryEntry.Key,
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
    }
    foreach (object obj in this.UpdateKeyTable)
    {
      DictionaryEntry dictionaryEntry = obj != null ? (DictionaryEntry) obj : new DictionaryEntry();
      DefaultDatabase.ExecuteNonQuery("dbo.SetSetting", new object[6]
      {
        (object) "@SettingValue",
        binary[RuntimeHelpers.GetObjectValue(dictionaryEntry.Key)],
        (object) "@SettingKey",
        dictionaryEntry.Key,
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
    }
    this.NewKeyTable.Clear();
    this.UpdateKeyTable.Clear();
    this._hashedSettings.Clear();
    this._hashedSettings = (Dictionary<string, object>) null;
  }

  private Hashtable ConvertAllValuesToBinary()
  {
    Hashtable binary = new Hashtable();
    try
    {
      foreach (KeyValuePair<string, object> hashedSetting in this.HashedSettings)
      {
        if (!(hashedSetting.Value is byte[]))
        {
          MemoryStream serializationStream = new MemoryStream();
          BinaryFormatter binaryFormatter = new BinaryFormatter();
          try
          {
            if (hashedSetting.Value != null)
              binaryFormatter.Serialize((Stream) serializationStream, RuntimeHelpers.GetObjectValue(hashedSetting.Value));
            binary.Add((object) hashedSetting.Key, (object) serializationStream.ToArray());
          }
          catch (SerializationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw;
          }
          finally
          {
            serializationStream.Close();
          }
        }
        else
        {
          binary.Add((object) (hashedSetting.Key + "_NATIVEBYTEARRAY"), RuntimeHelpers.GetObjectValue(hashedSetting.Value));
          if (this.UpdateKeyTable.ContainsKey((object) hashedSetting.Key))
          {
            this.UpdateKeyTable.Remove((object) hashedSetting.Key);
            this.UpdateKeyTable.Add((object) (hashedSetting.Key + "_NATIVEBYTEARRAY"), (object) null);
          }
          if (this.NewKeyTable.ContainsKey((object) hashedSetting.Key))
          {
            this.NewKeyTable.Remove((object) hashedSetting.Key);
            this.NewKeyTable.Add((object) (hashedSetting.Key + "_NATIVEBYTEARRAY"), (object) null);
          }
        }
      }
    }
    finally
    {
      Dictionary<string, object>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return binary;
  }

  private Assembly AppDomain_AssemblyResolve(object sender, ResolveEventArgs e) => this._assembly;

  private DictionaryEntry ConvertBinaryEntryToValue(
    DictionaryEntry entry,
    Assembly assemblyDeserializer)
  {
    DictionaryEntry dictionaryEntry;
    if (entry.Key.ToString().IndexOf("_NATIVEBYTEARRAY") == -1)
    {
      MemoryStream serializationStream1 = new MemoryStream((byte[]) entry.Value);
      try
      {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        dictionaryEntry = new DictionaryEntry(RuntimeHelpers.GetObjectValue(entry.Key), RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize((Stream) serializationStream1)));
      }
      catch (SerializationException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        if ((object) assemblyDeserializer != null)
        {
          try
          {
            this._assembly = assemblyDeserializer;
            if ((object) this._assembly != null)
            {
              BinaryFormatter binaryFormatter = new BinaryFormatter();
              MemoryStream serializationStream2 = new MemoryStream((byte[]) entry.Value);
              binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
              AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(this.AppDomain_AssemblyResolve);
              object objectValue = RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize((Stream) serializationStream2));
              dictionaryEntry = new DictionaryEntry(RuntimeHelpers.GetObjectValue(entry.Key), RuntimeHelpers.GetObjectValue(objectValue));
            }
          }
          catch (Exception ex2)
          {
            ProjectData.SetProjectError(ex2);
            MGASystems.IMS.Forms.Settings.Settings.Instance.DeleteSetting(entry.Key.ToString(), true);
            ProjectData.ClearProjectError();
          }
          finally
          {
            if ((object) this._assembly != null)
            {
              AppDomain.CurrentDomain.AssemblyResolve -= new ResolveEventHandler(this.AppDomain_AssemblyResolve);
              this._assembly = (Assembly) null;
            }
          }
        }
        else
          MGASystems.IMS.Forms.Settings.Settings.Instance.DeleteSetting(entry.Key.ToString(), true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        serializationStream1.Close();
      }
    }
    else
      dictionaryEntry = new DictionaryEntry((object) entry.Key.ToString().Replace("_NATIVEBYTEARRAY", ""), RuntimeHelpers.GetObjectValue(entry.Value));
    return dictionaryEntry;
  }
}
