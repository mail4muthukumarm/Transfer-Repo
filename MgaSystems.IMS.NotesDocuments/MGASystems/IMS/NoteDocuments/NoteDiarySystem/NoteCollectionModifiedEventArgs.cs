// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteCollectionModifiedEventArgs
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.NoteDiarySystem;

public class NoteCollectionModifiedEventArgs : EventArgs
{
  private NoteCollections _collectionModified;

  public NoteCollectionModifiedEventArgs(NoteCollections collectionModified)
  {
    this._collectionModified = NoteCollections.All;
    this._collectionModified = collectionModified;
  }

  public NoteCollections CollectionModified => this._collectionModified;
}
