// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.SendProducerDiaries
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[StandardModule]
public sealed class SendProducerDiaries
{
  internal static void SendDiaryNotes()
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string str1 = "SELECT NoteTypeID FROM lstNoteTypes WITH (NOLOCK) WHERE AutomationCode = @AC";
    int noteType = 0;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str1, new object[2]
    {
      (object) "@AC",
      (object) "ProdR"
    }));
    if (objectValue != null && objectValue != DBNull.Value)
      noteType = Conversions.ToInteger(objectValue);
    Guid userGuid = CurrentUser.Instance.UserGUID;
    Guid creatorGUID = !SystemSettings.GetSetting<bool>("NoteProducerDiariesFrom", false) ? CurrentUser.Instance.UserGUID : DefaultDatabase.ExecuteScalar<Guid>(CommandType.StoredProcedure, "GetUserInfoForAdmin1");
    List<Guid> guidList = new List<Guid>();
    DataTable dataTable1 = DefaultDatabase.ExecuteDataTable("GetDiaryUsersOnProducerRequirements");
    string empty3 = string.Empty;
    try
    {
      foreach (DataRow row in dataTable1.Rows)
      {
        guidList.Clear();
        string str2 = "30";
        string empty4 = string.Empty;
        if (row[2] != DBNull.Value)
          str2 = row[2].ToString();
        if (row[1] != DBNull.Value)
          empty4 = row[1].ToString();
        guidList.Add((Guid) row[0]);
        string subject = $"[{empty4}] - Producer Requirements Expire in {str2} days or Less";
        string body = $"A requirement on producer location '{empty4}' is about to expire in {str2} days or Less";
        Note_System.Instance.NonInteractive.CreateNote(noteType, subject, creatorGUID, body, false, guidList.ToArray());
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string empty5 = string.Empty;
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable("GetDiaryUsersOnProducerLicenses");
    try
    {
      foreach (DataRow row in dataTable2.Rows)
      {
        guidList.Clear();
        string str3 = "license";
        if (row[2] != DBNull.Value && row[2].ToString().Length > 0)
          str3 = $"{str3} with number '{row[2].ToString()}'";
        guidList.Add((Guid) row[0]);
        string empty6 = string.Empty;
        if (row[1] != DBNull.Value)
          empty6 = row[1].ToString();
        string subject = $"[{empty6}] - Producer Licenses Expire in 30 days or less";
        string body = $"A {str3} on producer location '{empty6}' is about to expire.";
        Note_System.Instance.NonInteractive.CreateNote(0, subject, creatorGUID, body, false, guidList.ToArray());
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  internal static void SendDriversDiaries()
  {
    List<Guid> guidList = new List<Guid>();
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    string empty4 = string.Empty;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetDiaryUsrsOnDrivers");
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        guidList.Clear();
        string empty5 = string.Empty;
        string str1 = string.Empty;
        empty1 = string.Empty;
        bool popup = false;
        string str2 = "License";
        if (row["LicenseNumber"] != DBNull.Value && row["LicenseNumber"].ToString().Length > 0)
          str2 = $"{str2} # '{row["LicenseNumber"].ToString()}'";
        if (row["LastName"] != DBNull.Value && row["LastName"].ToString().Length > 0)
          str1 = row["LastName"].ToString();
        if (row["FirstName"] != DBNull.Value && row["FirstName"].ToString().Length > 0)
          str1 = $"{str1}, {row["FirstName"].ToString()}";
        guidList.Add((Guid) row[0]);
        string subject = $"Control #{row["ControlNo"].ToString()}. {str1} [{str2}] expires {row["LicenseExpDate"].ToString()}";
        if (row["NoteBody"] != DBNull.Value && row["NoteBody"].ToString().Length > 0)
          empty5 = row["NoteBody"].ToString();
        if (row["PopUpNote"] != DBNull.Value)
          popup = Conversions.ToBoolean(row["PopUpNote"]);
        Note_System.Instance.NonInteractive.CreateNote(0, subject, userGuid, empty5, false, guidList.ToArray(), popup);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
