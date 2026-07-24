// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteBindFailureReason
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System.Data;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.NoteDiarySystem;

public class NoteBindFailureReason
{
  private string _description;
  private bool _requiredToBind;
  private bool _requiredToQuote;
  private int _noteTypeID;

  public NoteBindFailureReason(DataRow row)
  {
    this._description = (string) row[nameof (Description)];
    this._requiredToBind = (bool) row[nameof (RequiredToBind)];
    this._requiredToQuote = (bool) row[nameof (RequiredToQuote)];
    this._noteTypeID = (int) row[nameof (NoteTypeID)];
  }

  public string Description => this._description;

  public bool RequiredToBind => this._requiredToBind;

  public bool RequiredToQuote => this._requiredToQuote;

  public int NoteTypeID => this._noteTypeID;
}
