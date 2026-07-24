// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentEmailsContext
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.IO;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public sealed class DocumentEmailsContext
{
  private Guid[] _documentGuids;
  private string[] _toRecipients;
  private string _subject;
  private bool _convertToPdf;
  private ISupportDocumentSystem _docSupport;
  private MemoryStream _htmlEmailBody;
  private string[] _ccList;
  private string[] _bcList;

  public DocumentEmailsContext(
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf)
  {
    this._documentGuids = documentGuids;
    this._toRecipients = toRecipients;
    this._subject = subject;
    this._convertToPdf = convertToPdf;
  }

  public DocumentEmailsContext(
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody)
  {
    this._documentGuids = documentGuids;
    this._toRecipients = toRecipients;
    this._subject = subject;
    this._convertToPdf = convertToPdf;
    this._htmlEmailBody = htmlEmailBody;
  }

  public DocumentEmailsContext(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf)
  {
    this._documentGuids = documentGuids;
    this._toRecipients = toRecipients;
    this._subject = subject;
    this._convertToPdf = convertToPdf;
    this._docSupport = docSupport;
  }

  public DocumentEmailsContext(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody)
  {
    this._documentGuids = documentGuids;
    this._toRecipients = toRecipients;
    this._subject = subject;
    this._convertToPdf = convertToPdf;
    this._htmlEmailBody = htmlEmailBody;
    this._docSupport = docSupport;
  }

  public DocumentEmailsContext(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody,
    string[] ccList)
  {
    this._documentGuids = documentGuids;
    this._toRecipients = toRecipients;
    this._subject = subject;
    this._convertToPdf = convertToPdf;
    this._htmlEmailBody = htmlEmailBody;
    this._docSupport = docSupport;
    this._ccList = ccList;
  }

  public DocumentEmailsContext(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody,
    string[] ccList,
    string[] bcList)
  {
    this._documentGuids = documentGuids;
    this._toRecipients = toRecipients;
    this._subject = subject;
    this._convertToPdf = convertToPdf;
    this._htmlEmailBody = htmlEmailBody;
    this._docSupport = docSupport;
    this._ccList = ccList;
    this._bcList = bcList;
  }

  public Guid[] GetDocumentGuids() => this._documentGuids;

  public string[] GetToRecipients() => this._toRecipients;

  public string Subject => this._subject;

  public ISupportDocumentSystem DocumentSupport => this._docSupport;

  public bool ConvertToPdf => this._convertToPdf;

  public MemoryStream htmlEmailBody => this._htmlEmailBody;

  public string[] GetCarbonCopyList => this._ccList;

  public string[] GetBCarbonCopyList => this._bcList;
}
