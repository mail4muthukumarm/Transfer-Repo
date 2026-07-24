// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.PendingNote
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data.Binding;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class PendingNote : BindingObject
{
  private Guid[] _diaryRecipients;

  public PendingNote(
    int noteType,
    string subject,
    Guid originatorGuid,
    string body,
    NoteSupportCache noteSupport,
    DateTime dueDate,
    Guid[] diaryRecipients,
    bool popup,
    bool IncludeEmail,
    bool mandatory,
    bool reqToBind)
  {
    this.NoteType = noteType;
    // ISSUE: reference to a compiler-generated field
    this._Subject = subject;
    this.OriginatorGuid = originatorGuid;
    // ISSUE: reference to a compiler-generated field
    this._Body = body;
    this.NoteSupport = noteSupport;
    // ISSUE: reference to a compiler-generated field
    this._DueDate = dueDate;
    this._diaryRecipients = diaryRecipients;
    this.Popup = popup;
    this.IncludeEmail = IncludeEmail;
    this.Mandatory = mandatory;
    this.RequiredToBind = reqToBind;
  }

  public bool Popup { get; }

  public int NoteType { get; }

  public string Subject { get; set; }

  public Guid OriginatorGuid { get; }

  public string Body { get; set; }

  public NoteSupportCache NoteSupport { get; }

  public DateTime DueDate { get; set; }

  public Guid AssignedTo { get; set; }

  public bool IncludeEmail { get; }

  public bool Mandatory { get; }

  public bool RequiredToBind { get; }

  public DateTime FinalDueDate => this._DueDate.AddDays(7.0);

  public Guid[] GetDiaryRecipients() => this._diaryRecipients;

  public void SetDiaryRecipients(Guid[] diaryRecipients) => this._diaryRecipients = diaryRecipients;
}
