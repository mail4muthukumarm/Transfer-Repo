// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.GlobalEventInfo
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

internal class GlobalEventInfo
{
  private int _noteAutomationId;
  internal readonly Guid EventGuid;
  internal readonly string StateId;
  internal readonly Guid? LineGuid;
  internal readonly Guid? ProducerGuid;
  internal readonly Guid? ProducerLocationGuid;
  internal readonly Guid? CompanyLocationGuid;
  internal readonly Guid? InHouseProducerGuid;
  internal readonly Guid? OfficeLocationGuid;
  internal readonly Guid? UnderwriterGuid;
  internal readonly Guid? IssuingOfficeGuid;
  internal readonly byte? PolicyTypeId;
  internal readonly DateTime? Effective;
  internal readonly DateTime? ExpirationDate;
  internal readonly string Subject;
  internal readonly string Body;
  internal readonly int RecipientId;
  internal readonly bool IsPopup;
  internal readonly int NoteType;
  internal readonly int? DiaryStartDate;
  internal readonly int? CompanyLicenceTypeId;
  internal readonly int? DueInDays;
  internal readonly int? TemplateId;
  internal readonly bool IncludeEmail;
  internal readonly bool Mandatory;
  internal readonly bool RequiredToBind;
  internal readonly int? StatusReasonID;

  internal GlobalEventInfo(
    int noteAutomationId,
    object eventGuid,
    object stateId,
    object lineGuid,
    object producerGuid,
    object producerLocationGuid,
    object companyLocationGuid,
    object inHouseProducerGuid,
    object officeLocationGuid,
    object underwriterGuid,
    object issuingOfficeGuid,
    object policyTypeId,
    object effective,
    string subject,
    string body,
    object recipientId,
    bool isPopup,
    object noteType,
    object diaryStartDate,
    object dueInDays,
    object expirationDate,
    object companyLicenceTypeId,
    object templateId,
    bool IncludeEmail,
    bool mandatory,
    bool reqToBind,
    object sReasonID)
  {
    this._noteAutomationId = noteAutomationId;
    object obj = eventGuid;
    this.EventGuid = obj != null ? (Guid) obj : new Guid();
    this.StateId = stateId as string;
    this.LineGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(lineGuid));
    this.ProducerGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(producerGuid));
    this.ProducerLocationGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(producerLocationGuid));
    this.CompanyLocationGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(companyLocationGuid));
    this.InHouseProducerGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(inHouseProducerGuid));
    this.OfficeLocationGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(officeLocationGuid));
    this.UnderwriterGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(underwriterGuid));
    this.IssuingOfficeGuid = GlobalEventInfo.CastValue<Guid>(RuntimeHelpers.GetObjectValue(issuingOfficeGuid));
    this.PolicyTypeId = GlobalEventInfo.CastValue<byte>(RuntimeHelpers.GetObjectValue(policyTypeId));
    this.Effective = GlobalEventInfo.CastValue<DateTime>(RuntimeHelpers.GetObjectValue(effective));
    this.ExpirationDate = GlobalEventInfo.CastValue<DateTime>(RuntimeHelpers.GetObjectValue(expirationDate));
    this.Subject = subject;
    this.Body = body;
    this.RecipientId = (int) recipientId;
    this.IsPopup = isPopup;
    this.NoteType = (int) noteType;
    this.DiaryStartDate = GlobalEventInfo.CastValue<int>(RuntimeHelpers.GetObjectValue(diaryStartDate));
    this.DueInDays = GlobalEventInfo.CastValue<int>(RuntimeHelpers.GetObjectValue(dueInDays));
    this.CompanyLicenceTypeId = GlobalEventInfo.CastValue<int>(RuntimeHelpers.GetObjectValue(companyLicenceTypeId));
    this.TemplateId = GlobalEventInfo.CastValue<int>(RuntimeHelpers.GetObjectValue(templateId));
    this.IncludeEmail = IncludeEmail;
    this.Mandatory = mandatory;
    this.RequiredToBind = reqToBind;
    this.StatusReasonID = GlobalEventInfo.CastValue<int>(RuntimeHelpers.GetObjectValue(sReasonID));
  }

  private static T? CastValue<T>(object value) where T : struct
  {
    return value != null ? new T?((T) value) : new T?();
  }

  internal void CopyToTblGlobalNoteAutomationRow(dsAdminGlobalNotes.tblGlobalNoteAutomationRow row)
  {
    row.NoteAutomationID = this._noteAutomationId;
    row.EventGuid = this.EventGuid;
    GlobalEventInfo.SetStringValue((DataRow) row, this.StateId, "StateId");
    GlobalEventInfo.SetNullableValue<Guid>(this.LineGuid, (DataRow) row, "LineGuid");
    GlobalEventInfo.SetNullableValue<Guid>(this.ProducerGuid, (DataRow) row, "ProducerGuid");
    GlobalEventInfo.SetNullableValue<Guid>(this.ProducerLocationGuid, (DataRow) row, "ProducerLocationGuid");
    GlobalEventInfo.SetNullableValue<Guid>(this.CompanyLocationGuid, (DataRow) row, "CompanyLocationGuid");
    GlobalEventInfo.SetNullableValue<Guid>(this.InHouseProducerGuid, (DataRow) row, "InHouseProducerGuid");
    GlobalEventInfo.SetNullableValue<Guid>(this.OfficeLocationGuid, (DataRow) row, "OfficeLocationGuid");
    GlobalEventInfo.SetNullableValue<Guid>(this.UnderwriterGuid, (DataRow) row, "UnderwriterGuid");
    GlobalEventInfo.SetNullableValue<Guid>(this.IssuingOfficeGuid, (DataRow) row, "IssuingOfficeGuid");
    GlobalEventInfo.SetNullableValue<byte>(this.PolicyTypeId, (DataRow) row, "PolicyTypeId");
    GlobalEventInfo.SetNullableValue<DateTime>(this.Effective, (DataRow) row, "Effective");
    GlobalEventInfo.SetNullableValue<DateTime>(this.ExpirationDate, (DataRow) row, "ExpirationDate");
    GlobalEventInfo.SetNullableValue<Guid>(this.LineGuid, (DataRow) row, "LineGuid");
    GlobalEventInfo.SetStringValue((DataRow) row, this.Subject, "NoteSubject");
    GlobalEventInfo.SetStringValue((DataRow) row, this.Body, "NoteBody");
    GlobalEventInfo.SetNullableValue<int>(this.DueInDays, (DataRow) row, "DueInDays");
    GlobalEventInfo.SetNullableValue<int>(new int?(this.RecipientId), (DataRow) row, "NoteAutomationRecipientID");
    GlobalEventInfo.SetNullableValue<bool>(new bool?(this.IsPopup), (DataRow) row, "Popup");
    GlobalEventInfo.SetNullableValue<int>(new int?(this.NoteType), (DataRow) row, "Type");
    GlobalEventInfo.SetNullableValue<int>(this.DiaryStartDate, (DataRow) row, "DiaryStartDateID");
    GlobalEventInfo.SetNullableValue<int>(this.CompanyLicenceTypeId, (DataRow) row, "CompanyLicenceTypeId");
    GlobalEventInfo.SetNullableValue<int>(this.TemplateId, (DataRow) row, "TemplateID");
    GlobalEventInfo.SetNullableValue<bool>(new bool?(this.IncludeEmail), (DataRow) row, "IncludeEmail");
    GlobalEventInfo.SetNullableValue<bool>(new bool?(this.Mandatory), (DataRow) row, "Mandatory");
    GlobalEventInfo.SetNullableValue<bool>(new bool?(this.RequiredToBind), (DataRow) row, "RequiredToBind");
    GlobalEventInfo.SetNullableValue<int>(new int?(this.NoteType), (DataRow) row, "StatusReasonID");
  }

  private static void SetStringValue(DataRow row, string value, string columnName)
  {
    if (string.IsNullOrEmpty(value))
      return;
    row[columnName] = (object) value;
  }

  private static void SetNullableValue<T>(T? value, DataRow row, string columnName) where T : struct
  {
    if (value.HasValue)
      row[columnName] = (object) value.Value;
    else
      row[columnName] = (object) DBNull.Value;
  }

  internal int NoteAutomationId
  {
    get => this._noteAutomationId;
    set => this._noteAutomationId = value;
  }
}
