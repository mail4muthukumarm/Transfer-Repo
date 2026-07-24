// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.GlobalNoteAutomationRecipient
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public abstract class GlobalNoteAutomationRecipient : ValidatingBindingObject
{
  public int cnID { get; set; }

  public int NoteAutomationID { get; set; }

  [NotificationProperty]
  public virtual Guid UserGuid { get; set; }

  [NotificationProperty]
  public virtual string UserName { get; set; }

  public GlobalNoteAutomationRecipient(
    int _cnID,
    int _noteAutomationID,
    Guid _userGuid,
    string _userName)
  {
    this.cnID = _cnID;
    this.NoteAutomationID = _noteAutomationID;
    this.UserGuid = _userGuid;
    this.UserName = _userName;
  }

  public static GlobalNoteAutomationRecipient Create(
    int _cnID,
    int _noteAutomationID,
    Guid _userGuid,
    string _userName)
  {
    return NotifyProxyTypeManager.Allocate<GlobalNoteAutomationRecipient>(new object[4]
    {
      (object) _cnID,
      (object) _noteAutomationID,
      (object) _userGuid,
      (object) _userName
    });
  }

  public static ObservableCollection<GlobalNoteAutomationRecipient> GetGlobalNoteAutomationRecipientList(
    int noteAutomationID)
  {
    EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT cnID, NoteAutomationID, UserGuid, UserName = (SELECT Name_FirstLast FROM tblUsers WHERE tblUsers.UserGUID = tblGlobalNoteAutomation_Recipients.UserGuid) FROM tblGlobalNoteAutomation_Recipients WHERE NoteAutomationID = @NoteAutomationID ORDER BY UserName", new object[2]
    {
      (object) "@NoteAutomationID",
      (object) noteAutomationID
    }).AsEnumerable();
    System.Func<DataRow, GlobalNoteAutomationRecipient> selector;
    // ISSUE: reference to a compiler-generated field
    if (GlobalNoteAutomationRecipient._Closure\u0024__.\u0024I18\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = GlobalNoteAutomationRecipient._Closure\u0024__.\u0024I18\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GlobalNoteAutomationRecipient._Closure\u0024__.\u0024I18\u002D0 = selector = (System.Func<DataRow, GlobalNoteAutomationRecipient>) ([SpecialName] (row) => GlobalNoteAutomationRecipient.Create(row.Field<int>("cnID"), row.Field<int>("NoteAutomationID"), row.Field<Guid>("UserGuid"), row.Field<string>("UserName")));
    }
    return new ObservableCollection<GlobalNoteAutomationRecipient>((IEnumerable<GlobalNoteAutomationRecipient>) source.Select<DataRow, GlobalNoteAutomationRecipient>(selector));
  }

  public static List<Guid> GetGlobalNoteAutomationRecipientGuidList(int noteAutomationID)
  {
    EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT UserGuid FROM tblGlobalNoteAutomation_Recipients WHERE NoteAutomationID = @NoteAutomationID", new object[2]
    {
      (object) "@NoteAutomationID",
      (object) noteAutomationID
    }).AsEnumerable();
    System.Func<DataRow, Guid> selector;
    // ISSUE: reference to a compiler-generated field
    if (GlobalNoteAutomationRecipient._Closure\u0024__.\u0024I19\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = GlobalNoteAutomationRecipient._Closure\u0024__.\u0024I19\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GlobalNoteAutomationRecipient._Closure\u0024__.\u0024I19\u002D0 = selector = (System.Func<DataRow, Guid>) ([SpecialName] (row) => row.Field<Guid>("UserGuid"));
    }
    return new List<Guid>((IEnumerable<Guid>) source.Select<DataRow, Guid>(selector));
  }

  public static void UpdateRecipientList(
    int noteAutomationID,
    ObservableCollection<GlobalNoteAutomationRecipient> recipientList)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblGlobalNoteAutomation_Recipients WHERE NoteAutomationID = @NoteAutomationID", new object[2]
    {
      (object) "@NoteAutomationID",
      (object) noteAutomationID
    });
    try
    {
      foreach (GlobalNoteAutomationRecipient recipient in (Collection<GlobalNoteAutomationRecipient>) recipientList)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblGlobalNoteAutomation_Recipients (NoteAutomationID, UserGuid) VALUES (@NoteAutomationID, @UserGuid)", new object[4]
        {
          (object) "@NoteAutomationID",
          (object) noteAutomationID,
          (object) "@UserGuid",
          (object) recipient.UserGuid
        });
    }
    finally
    {
      IEnumerator<GlobalNoteAutomationRecipient> enumerator;
      enumerator?.Dispose();
    }
  }
}
