// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.AssociatedEntity
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public sealed class AssociatedEntity
{
  private string _emailAddress;
  private string _contactType;
  private string _contactName;

  public AssociatedEntity(string emailAddress, string contactType, string contactName)
  {
    this._emailAddress = emailAddress;
    this._contactType = contactType;
    this._contactName = contactName;
  }

  public override string ToString()
  {
    return $"{this.ContactType}: {this.ContactName}, {this.EmailAddress}";
  }

  public string ContactName => this._contactName;

  public string ContactType => this._contactType;

  public string EmailAddress => this._emailAddress;
}
