// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.Common
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[StandardModule]
[SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
public sealed class Common
{
  private static string _connectionString;
  private static Control _uiContext;
  private static ICurrentUser _user;
  private static string _documentStoreBinarySerializationType;
  private static bool _blackboxMode;

  public static bool BlackBoxMode
  {
    get => MGASystems.IMS.NoteDocuments.Common._blackboxMode;
    set => MGASystems.IMS.NoteDocuments.Common._blackboxMode = value;
  }

  internal static Control UIContext
  {
    get => MGASystems.IMS.NoteDocuments.Common._uiContext != null ? MGASystems.IMS.NoteDocuments.Common._uiContext : throw new NotInitializedException();
  }

  internal static string ConnectionString
  {
    get
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MGASystems.IMS.NoteDocuments.Common._connectionString, string.Empty, false) != 0 ? MGASystems.IMS.NoteDocuments.Common._connectionString : throw new NotInitializedException();
    }
  }

  internal static bool UserIsLoggedIn => MGASystems.IMS.NoteDocuments.Common._user.IsLoggedIn;

  internal static Guid UserGUID => MGASystems.IMS.NoteDocuments.Common._user.UserGUID;

  internal static int UserID => MGASystems.IMS.NoteDocuments.Common._user.UserID;

  public static void Initialize(string connectionString, Control uiContext, ICurrentUser user)
  {
    MGASystems.IMS.NoteDocuments.Common._connectionString = connectionString;
    MGASystems.IMS.NoteDocuments.Common._uiContext = uiContext;
    MGASystems.IMS.NoteDocuments.Common._user = user;
    MGASystems.IMS.NoteDocuments.Common.UpdateOutlookMessageSaveAsUnicode();
  }

  private static void UpdateOutlookMessageSaveAsUnicode()
  {
    try
    {
      if (!SystemInfo.IsOfficeAppAvailable(SystemInfo.OfficeApps.Outlook, SystemInfo.WordVersion.Office2003))
        return;
      bool flag = MGASystems.IMS.NoteDocuments.Common.SaveOutlookMessagesInUnicode();
      using (RegistryKey registryKey1 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office"))
      {
        if (registryKey1 == null)
          return;
        string[] subKeyNames = registryKey1.GetSubKeyNames();
        int index = 0;
        while (index < subKeyNames.Length)
        {
          string Expression = subKeyNames[index];
          if (Versioned.IsNumeric((object) Expression))
          {
            using (RegistryKey registryKey2 = registryKey1.OpenSubKey($"{Expression}\\Outlook\\Options\\General", true))
            {
              if (registryKey2 != null)
              {
                object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("MSGFormat"));
                if (objectValue != null)
                {
                  int integer = Conversions.ToInteger(objectValue);
                  if (flag && integer != 1)
                    registryKey2.SetValue("MSGFormat", (object) 1);
                  else if (!flag)
                  {
                    if (integer != 0)
                      registryKey2.SetValue("MSGFormat", (object) 0);
                  }
                }
                else
                  registryKey2.SetValue("MSGFormat", (object) 0, RegistryValueKind.DWord);
              }
            }
          }
          checked { ++index; }
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private static bool SaveOutlookMessagesInUnicode()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select settingValueBool from tblSystemSettings where setting = @value", new object[2]
    {
      (object) "@value",
      (object) "OutlookMessageSaveAsUnicode"
    }));
    bool flag;
    if (objectValue == null)
    {
      MGASystems.Common.SystemSettings.SetBoolSetting("OutlookMessageSaveAsUnicode", true);
      flag = true;
    }
    else
      flag = Conversions.ToBoolean(objectValue);
    return flag;
  }

  public static string FetchColumnDataType(string tableName, string columnName)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("FetchColumnInformation", new object[4]
    {
      (object) "@tableName",
      (object) tableName,
      (object) "@columnName",
      (object) columnName
    });
    int num;
    if (dataTable == null)
    {
      num = 0;
    }
    else
    {
      DataRowCollection rows = dataTable.Rows;
      if (rows == null)
      {
        num = 0;
      }
      else
      {
        DataRow row = rows[0];
        num = row != null ? (row.Field<bool>("is_filestream") ? 1 : 0) : 0;
      }
    }
    bool flag = num != 0;
    string str;
    if (dataTable == null)
    {
      str = (string) null;
    }
    else
    {
      DataRowCollection rows = dataTable.Rows;
      if (rows == null)
      {
        str = (string) null;
      }
      else
      {
        DataRow row = rows[0];
        str = row != null ? row.Field<string>("data_Type") : (string) null;
      }
    }
    if (str == null)
      str = "image";
    return str + (flag ? "_filestream" : "");
  }

  public static string DocumentStoreBinarySerializationType
  {
    get
    {
      if (string.IsNullOrEmpty(MGASystems.IMS.NoteDocuments.Common._documentStoreBinarySerializationType))
      {
        try
        {
          MGASystems.IMS.NoteDocuments.Common._documentStoreBinarySerializationType = MGASystems.IMS.NoteDocuments.Common.FetchColumnDataType("tblDocumentStore", "Document");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentHandleError(ex);
          MGASystems.IMS.NoteDocuments.Common._documentStoreBinarySerializationType = "image";
          ProjectData.ClearProjectError();
        }
      }
      return MGASystems.IMS.NoteDocuments.Common._documentStoreBinarySerializationType;
    }
  }
}
