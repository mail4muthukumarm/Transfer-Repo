// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.VerifyNotesOnPolicyOverride
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class VerifyNotesOnPolicyOverride
{
  public virtual List<NoteBindFailureReason> QueryRequiredNotesOnPolicy(Guid quote)
  {
    List<NoteBindFailureReason> bindFailureReasonList = new List<NoteBindFailureReason>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("NoteSystem_VerifyNotesOnPolicy", new object[2]
    {
      (object) "@quoteGuid",
      (object) quote
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        bindFailureReasonList.Add(new NoteBindFailureReason(row));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return bindFailureReasonList;
  }
}
