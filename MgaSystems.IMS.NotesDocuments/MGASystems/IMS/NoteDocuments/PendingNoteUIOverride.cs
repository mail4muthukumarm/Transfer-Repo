// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.PendingNoteUIOverride
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class PendingNoteUIOverride
{
  public virtual bool HasUI => !MGASystems.IMS.NoteDocuments.Common.BlackBoxMode;

  public virtual Form CreateUI(List<PendingNote> noteList)
  {
    return ObjectFactory.Instance.CreateFormEX(typeof (PendingNoteForm), (object) noteList);
  }

  public virtual Form CreateUI(List<PendingNote> noteList, int quoteID)
  {
    return ObjectFactory.Instance.CreateFormEX(typeof (PendingNoteForm), (object) noteList, (object) quoteID);
  }

  public void ProcessBoundNotesOnClient(int quoteID, Dictionary<Guid, PendingNote> boundNoteList)
  {
    ObjectFactory.Instance.CreateObjectAs<PendingNotePostProcessorOverride>().ProcessBoundNotesOnClient(quoteID, boundNoteList);
  }
}
