// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteDiarySystem.Note_System
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.NoteDiarySystem;

[SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
public class Note_System
{
  private static Note_System _noteSystem;
  private Note_System.NonInteractiveNoteManipulator _nonInteractiveNoteManipulator;
  private Note_System.UIInteractiveNoteManipulator _uiInteractiveNoteManipulator;

  [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
  public event Note_System.NoteCollectionModifiedEventhandler NoteCollectionModified;

  [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
  public event Note_System.NoteDeletedEventhandler NoteDeleted;

  private Note_System()
  {
  }

  public static Note_System Instance
  {
    get
    {
      if (Note_System._noteSystem == null)
        Note_System._noteSystem = new Note_System();
      return Note_System._noteSystem;
    }
  }

  public Note_System.NonInteractiveNoteManipulator NonInteractive
  {
    get
    {
      if (this._nonInteractiveNoteManipulator == null)
        this._nonInteractiveNoteManipulator = new Note_System.NonInteractiveNoteManipulator(this);
      return this._nonInteractiveNoteManipulator;
    }
  }

  public Note_System.UIInteractiveNoteManipulator UIInteractive
  {
    get
    {
      if (this._uiInteractiveNoteManipulator == null)
        this._uiInteractiveNoteManipulator = new Note_System.UIInteractiveNoteManipulator(this);
      return this._uiInteractiveNoteManipulator;
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
  public void FireCollectionModified(NoteCollections collection)
  {
    // ISSUE: reference to a compiler-generated field
    Note_System.NoteCollectionModifiedEventhandler collectionModifiedEvent = this.NoteCollectionModifiedEvent;
    if (collectionModifiedEvent == null)
      return;
    collectionModifiedEvent((object) this, new NoteCollectionModifiedEventArgs(collection));
  }

  private void FireNoteDeleted(Guid deletedNoteGUID)
  {
    // ISSUE: reference to a compiler-generated field
    Note_System.NoteDeletedEventhandler noteDeletedEvent = this.NoteDeletedEvent;
    if (noteDeletedEvent == null)
      return;
    noteDeletedEvent((object) this, new NoteDeletedEventArgs(deletedNoteGUID));
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public override string ToString() => base.ToString();

  [EditorBrowsable(EditorBrowsableState.Never)]
  public override int GetHashCode() => base.GetHashCode();

  [EditorBrowsable(EditorBrowsableState.Never)]
  public override bool Equals(object obj) => base.Equals(RuntimeHelpers.GetObjectValue(obj));

  [SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")]
  public delegate void NotesFoundEventHandler(object sender, NotesFoundEventArgs e);

  [SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")]
  public delegate void NoteCollectionModifiedEventhandler(
    object sender,
    NoteCollectionModifiedEventArgs e);

  [SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")]
  public delegate void NoteDeletedEventhandler(object sender, NoteDeletedEventArgs e);

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class NonInteractiveNoteManipulator
  {
    private Note_System _noteSystem;
    private int _systemNoteType;

    public NonInteractiveNoteManipulator(Note_System noteSystem)
    {
      this._systemNoteType = -99;
      this._noteSystem = noteSystem;
    }

    protected Note_System NoteSystem => this._noteSystem;

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void TagNoteWithContext(Guid noteGuid, string context, IRecreatableEntity noteSupport)
    {
      if (context == null)
        throw new ArgumentNullException(nameof (context));
      if (noteSupport == null)
        throw new InvalidOperationException("NoteSupport cannot be null");
      if (noteSupport.EntityGuid.Equals(Guid.Empty))
        throw new InvalidOperationException("EntityGUID cannot be empty");
      if (context.Length > 50)
        throw new InvalidOperationException("Context cannot be longer than 200 characters");
      if (string.IsNullOrEmpty(context))
        throw new InvalidOperationException("Context cannot be empty");
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteStore  SET Context = @Context  WHERE [ID] = @NoteGUID", (object) "@Context", (object) context, (object) "@NoteGuid", (object) noteGuid);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public Guid FindNoteGuidByContext(string context, IRecreatableEntity noteSupport)
    {
      if (string.IsNullOrEmpty(context))
        throw new ArgumentNullException(nameof (context));
      if (noteSupport == null)
        throw new InvalidOperationException("NoteSupport cannot be null");
      if (noteSupport.EntityGuid.Equals(Guid.Empty))
        throw new InvalidOperationException("EntityGUID cannot be empty");
      if (context.Length > 50)
        throw new InvalidOperationException("Context cannot be longer than 200 characters");
      if (string.IsNullOrEmpty(context))
        throw new InvalidOperationException("Context cannot be empty");
      return Database.Instance.QueryText.PerformScalarQueryGuid("SELECT dbo.tblNoteStore.ID FROM dbo.tblNoteEntities (NOLOCK) INNER JOIN dbo.tblNoteStore ON dbo.tblNoteEntities.NoteGUID = dbo.tblNoteStore.ID WHERE (dbo.tblNoteEntities.AssociatedEntityGUID = @EntityGUID) AND (dbo.tblNoteStore.Context = @Context)", (object) "@EntityGUID", (object) noteSupport.EntityGuid, (object) "@Context", (object) context);
    }

    public static void UpdateGlobalNoteEvent(
      int noteAutomationId,
      Guid eventGuid,
      string stateId,
      Guid? lineGuid,
      Guid? producerGuid,
      Guid? producerLocationGuid,
      Guid? companyLocationGuid,
      Guid? inHouseProducerGuid,
      Guid? officeLocationGuid,
      Guid? underwriterGuid,
      Guid? issuingOfficeGuid,
      byte? policyTypeId,
      DateTime? effective,
      DateTime? expirationDate,
      string subject,
      string body,
      int? dueInDays,
      int recipientId,
      bool popup,
      int type,
      int? diaryStartDateId,
      int? companyLicenceTypeId,
      int? templateId,
      bool includeEmail,
      bool mandatory,
      bool requiredToBind,
      int? statusReasonID)
    {
      if (!string.IsNullOrEmpty(stateId) && stateId.Length > 2)
        throw new ArgumentException("Cannot be more than two characters", "stateID");
      if (subject.Length > 300)
        throw new ArgumentException("Cannot be more than 300 characters", "stateID");
      if (body.Length > 500)
        throw new ArgumentException("Cannot be more than 500 characters", "stateID");
      DefaultDatabase.ExecuteNonQuery("NoteSystem_UpdateGlobalNoteAutomationEvent", new object[54]
      {
        (object) "@noteAutomationId",
        (object) noteAutomationId,
        (object) "@eventGuid",
        (object) eventGuid,
        (object) "@stateId",
        (object) stateId,
        (object) "@lineGuid",
        (object) lineGuid,
        (object) "@producerGuid",
        (object) producerGuid,
        (object) "@producerLocationGuid",
        (object) producerLocationGuid,
        (object) "@companyLocationGuid",
        (object) companyLocationGuid,
        (object) "@inHouseProducerGuid",
        (object) inHouseProducerGuid,
        (object) "@officeLocationGuid",
        (object) officeLocationGuid,
        (object) "@underwriterGuid",
        (object) underwriterGuid,
        (object) "@issuingOfficeGuid",
        (object) issuingOfficeGuid,
        (object) "@policyTypeId",
        (object) policyTypeId,
        (object) "@effective",
        (object) effective,
        (object) "@expirationDate",
        (object) expirationDate,
        (object) "@noteSubject",
        (object) subject,
        (object) "@noteBody",
        (object) body,
        (object) "@dueInDays",
        (object) dueInDays,
        (object) "@noteAutomationRecipientId",
        (object) recipientId,
        (object) "@popup",
        (object) popup,
        (object) "@type",
        (object) type,
        (object) "@diaryStartDateId",
        (object) diaryStartDateId,
        (object) "@companyLicenceTypeId",
        (object) companyLicenceTypeId,
        (object) "@templateId",
        (object) templateId,
        (object) "@IncludeEmail",
        (object) includeEmail,
        (object) "@Mandatory",
        (object) mandatory,
        (object) "@RequiredToBind",
        (object) requiredToBind,
        (object) "@StatusReasonID",
        (object) statusReasonID
      });
    }

    public static int InsertGlobalNoteEvent(
      Guid eventGuid,
      string stateId,
      Guid? lineGuid,
      Guid? producerGuid,
      Guid? producerLocationGuid,
      Guid? companyLocationGuid,
      Guid? inHouseProducerGuid,
      Guid? officeLocationGuid,
      Guid? underwriterGuid,
      Guid? issuingOfficeGuid,
      byte? policyTypeId,
      DateTime? effective,
      DateTime? expirationDate,
      string subject,
      string body,
      int? dueInDays,
      int recipientId,
      bool popup,
      int type,
      int? diaryStartDateId,
      int? companyLicenceTypeId,
      int? templateId,
      bool includeEmail,
      bool mandatory,
      bool requiredToBind,
      int? statusReasonID)
    {
      if (!string.IsNullOrEmpty(stateId) && stateId.Length > 2)
        throw new ArgumentException("Cannot be more than two characters", "stateID");
      if (subject.Length > 300)
        throw new ArgumentException("Cannot be more than 300 characters", "stateID");
      if (body.Length > 500)
        throw new ArgumentException("Cannot be more than 500 characters", "stateID");
      int num = 0;
      Dictionary<string, DbParameter> dictionary = new Dictionary<string, DbParameter>();
      DbParameter parameter = DefaultDatabase.CreateParameter(ParameterDirection.Output, "@newNoteAutomationId", (object) num);
      dictionary.Add("@eventGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@eventGuid", (object) eventGuid));
      dictionary.Add("@stateId", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@stateId", (object) stateId));
      dictionary.Add("@lineGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@lineGuid", (object) lineGuid));
      dictionary.Add("@producerGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@producerGuid", (object) producerGuid));
      dictionary.Add("@producerLocationGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@producerLocationGuid", (object) producerLocationGuid));
      dictionary.Add("@companyLocationGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@companyLocationGuid", (object) companyLocationGuid));
      dictionary.Add("@inHouseProducerGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@inHouseProducerGuid", (object) inHouseProducerGuid));
      dictionary.Add("@officeLocationGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@officeLocationGuid", (object) officeLocationGuid));
      dictionary.Add("@underwriterGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@underwriterGuid", (object) underwriterGuid));
      dictionary.Add("@issuingOfficeGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@issuingOfficeGuid", (object) issuingOfficeGuid));
      dictionary.Add("@policyTypeId", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@policyTypeId", (object) policyTypeId));
      dictionary.Add("@effective", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@effective", (object) effective));
      dictionary.Add("@expirationDate", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@expirationDate", (object) expirationDate));
      dictionary.Add("@noteSubject", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@noteSubject", (object) subject));
      dictionary.Add("@noteBody", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@noteBody", (object) body));
      dictionary.Add("@dueInDays", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@dueInDays", (object) dueInDays));
      dictionary.Add("@noteAutomationRecipientId", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@noteAutomationRecipientId", (object) recipientId));
      dictionary.Add("@popup", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@popup", (object) popup));
      dictionary.Add("@type", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@type", (object) type));
      dictionary.Add("@diaryStartDateId", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@diaryStartDateId", (object) diaryStartDateId));
      dictionary.Add("@companyLicenceTypeId", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@companyLicenceTypeId", (object) companyLicenceTypeId));
      dictionary.Add("@TemplateId", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@TemplateId", (object) templateId));
      dictionary.Add("@newNoteAutomationId", parameter);
      dictionary.Add("@IncludeEmail", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@IncludeEmail", (object) includeEmail));
      dictionary.Add("@Mandatory", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@Mandatory", (object) mandatory));
      dictionary.Add("@RequiredToBind", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@RequiredToBind", (object) requiredToBind));
      dictionary.Add("@StatusReasonID", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@StatusReasonID", (object) statusReasonID));
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "NoteSystem_InsertGlobalNoteAutomationEvent", (CommandArgumentType) 2, new object[1]
      {
        (object) dictionary
      });
      return Conversions.ToInteger(parameter.Value);
    }

    public static void DeleteGlobalNoteEvent(int noteAutomationId)
    {
      DefaultDatabase.ExecuteNonQuery("NoteSystem_DeleteGlobalNoteAutomationEvent", new object[2]
      {
        (object) "@noteAutomationId",
        (object) noteAutomationId
      });
    }

    public Guid CreateNote(
      Guid noteGUID,
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs)
    {
      return this.InternalCreateNote(noteGUID, noteType, subject, creatorGUID, body, @internal, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, false);
    }

    public Guid CreateNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs)
    {
      return this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, false);
    }

    public Guid CreateNote(
      Guid noteguid,
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline)
    {
      return this.InternalCreateNote(noteguid, noteType, subject, creatorGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, false);
    }

    public Guid CreateNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline)
    {
      return this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, false);
    }

    public Guid CreateNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs)
    {
      return this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, false);
    }

    public Guid CreateNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline)
    {
      return this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, false);
    }

    public Guid CreateNote(
      Guid noteGUID,
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      bool popup)
    {
      return this.InternalCreateNote(noteGUID, noteType, subject, creatorGUID, body, @internal, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, popup);
    }

    public Guid CreateNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      bool popup)
    {
      return this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, popup);
    }

    public Guid CreateNote(
      Guid noteguid,
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      return this.InternalCreateNote(noteguid, noteType, subject, creatorGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup);
    }

    public Guid CreateNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      return this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup);
    }

    public Guid CreateNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs,
      bool popup)
    {
      return this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, popup);
    }

    public Guid CreateNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      return this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup);
    }

    private Guid InternalCreateNote(
      Guid newNoteGUID,
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      if (diaryRecipientGUIDs != null && recipientGUIDs != null)
      {
        List<Guid> guidList1 = new List<Guid>();
        List<Guid> guidList2 = new List<Guid>();
        Guid[] guidArray1 = diaryRecipientGUIDs;
        int index1 = 0;
        while (index1 < guidArray1.Length)
        {
          Guid guid = guidArray1[index1];
          guidList2.Add(guid);
          checked { ++index1; }
        }
        Guid[] guidArray2 = recipientGUIDs;
        int index2 = 0;
        while (index2 < guidArray2.Length)
        {
          Guid guid = guidArray2[index2];
          if (!guidList2.Contains(guid))
            guidList1.Add(guid);
          checked { ++index2; }
        }
        recipientGUIDs = guidList1.ToArray();
      }
      if (noteType == 0)
        noteType = -1;
      Guid note = (Guid) Database.Instance.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(this.QuerySet_CreateNote), new object[1]
      {
        (object) new Note_System.NonInteractiveNoteManipulator.InternalCreateNoteArgs(newNoteGUID, noteType, subject, creatorGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup)
      });
      if (recipientGUIDs != null && recipientGUIDs.Length > 0)
      {
        this.NoteSystem.FireCollectionModified(NoteCollections.NotesUnbound);
        this.NoteSystem.FireCollectionModified(NoteCollections.NoteEntriesOpen);
      }
      if (diaryRecipientGUIDs == null || diaryRecipientGUIDs.Length <= 0)
        return note;
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      return note;
    }

    private Guid InternalCreateNote(
      Guid newNoteGUID,
      int noteType,
      string subject,
      int systemEntityID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      if (diaryRecipientGUIDs != null && recipientGUIDs != null)
      {
        List<Guid> guidList1 = new List<Guid>();
        List<Guid> guidList2 = new List<Guid>();
        Guid[] guidArray1 = diaryRecipientGUIDs;
        int index1 = 0;
        while (index1 < guidArray1.Length)
        {
          Guid guid = guidArray1[index1];
          guidList2.Add(guid);
          checked { ++index1; }
        }
        Guid[] guidArray2 = recipientGUIDs;
        int index2 = 0;
        while (index2 < guidArray2.Length)
        {
          Guid guid = guidArray2[index2];
          if (!guidList2.Contains(guid))
            guidList1.Add(guid);
          checked { ++index2; }
        }
        recipientGUIDs = guidList1.ToArray();
      }
      if (noteType == 0)
        noteType = -1;
      Guid note = (Guid) Database.Instance.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(this.QuerySet_CreateNote), new object[1]
      {
        (object) new Note_System.NonInteractiveNoteManipulator.InternalCreateNoteArgs(newNoteGUID, noteType, subject, systemEntityID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup)
      });
      if (recipientGUIDs != null && recipientGUIDs.Length > 0)
      {
        this.NoteSystem.FireCollectionModified(NoteCollections.NotesUnbound);
        this.NoteSystem.FireCollectionModified(NoteCollections.NoteEntriesOpen);
      }
      if (diaryRecipientGUIDs == null || diaryRecipientGUIDs.Length <= 0)
        return note;
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      return note;
    }

    private object QuerySet_CreateNote(object sender, QuerySetHandlerEventArgs e)
    {
      Note_System.NonInteractiveNoteManipulator.InternalCreateNoteArgs internalCreateNoteArgs = (Note_System.NonInteractiveNoteManipulator.InternalCreateNoteArgs) e.GetArgs()[0];
      DatabaseQueryText queryText = e.Database.QueryText;
      Guid noteGuid = internalCreateNoteArgs.NoteGUID;
      Guid entryGUID = Guid.NewGuid();
      DateTime dateTime = DateAndTime.Now;
      if (SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime", false))
        dateTime = CurrentUser.ServerTime;
      if (internalCreateNoteArgs.IsSystemNote)
        queryText.PerformNonQuery("INSERT INTO dbo.tblNoteStore ([ID], CreatedDate, Type, Subject, SystemEntityID) VALUES (@NoteGUID, @CreatedDate, @Type, @Subject, @SystemEntityID)", (object) "@NoteGUID", (object) noteGuid, (object) "@CreatedDate", (object) dateTime, (object) "@Type", (object) internalCreateNoteArgs.NoteType, (object) "@Subject", (object) internalCreateNoteArgs.Subject, (object) "@SystemEntityID", (object) internalCreateNoteArgs.SystemEntityID);
      else
        queryText.PerformNonQuery("INSERT INTO dbo.tblNoteStore ([ID], CreatedDate, Type, Subject, UserGUID) VALUES (@NoteGUID, @CreatedDate, @Type, @Subject, @UserGUID)", (object) "@NoteGUID", (object) noteGuid, (object) "@CreatedDate", (object) dateTime, (object) "@Type", (object) internalCreateNoteArgs.NoteType, (object) "@Subject", (object) internalCreateNoteArgs.Subject, (object) "@UserGUID", (object) internalCreateNoteArgs.CreatorGUID);
      if (internalCreateNoteArgs.IsSystemNote)
        queryText.PerformNonQuery("INSERT INTO dbo.tblNoteEntries ([ID], NoteGUID, Body, CreatedDate, Internal, SystemEntityID) VALUES (@EntryGUID, @NoteGUID, @Body, @CreatedDate, @Internal, @SystemEntityID)", (object) "@EntryGUID", (object) entryGUID, (object) "@NoteGUID", (object) noteGuid, (object) "@Body", (object) internalCreateNoteArgs.Body, (object) "@CreatedDate", (object) dateTime, (object) "@Internal", (object) internalCreateNoteArgs.Internal, (object) "@SystemEntityID", (object) internalCreateNoteArgs.SystemEntityID);
      else
        queryText.PerformNonQuery("INSERT INTO dbo.tblNoteEntries ([ID], NoteGUID, Body, CreatedDate, Internal, UserGUID,EditedByUserGUID) VALUES (@EntryGUID, @NoteGUID, @Body, @CreatedDate, @Internal, @UserGUID,@EditedByUserGUID)", (object) "@EntryGUID", (object) entryGUID, (object) "@NoteGUID", (object) noteGuid, (object) "@Body", (object) internalCreateNoteArgs.Body, (object) "@CreatedDate", (object) dateTime, (object) "@Internal", (object) internalCreateNoteArgs.Internal, (object) "@EditedByUserGUID", (object) internalCreateNoteArgs.CreatorGUID, (object) "@UserGUID", (object) internalCreateNoteArgs.CreatorGUID);
      if (internalCreateNoteArgs.RecipientGUIDs != null)
      {
        Guid[] recipientGuiDs = internalCreateNoteArgs.RecipientGUIDs;
        int index = 0;
        while (index < recipientGuiDs.Length)
        {
          Guid guid = recipientGuiDs[index];
          queryText.PerformNonQuery("INSERT INTO tblNoteRecipients ([ID], EntryGUID, UserGUID) VALUES (@RecipientGUID,@EntryGUID,@UserGUID)", (object) "@RecipientGUID", (object) Guid.NewGuid(), (object) "@EntryGUID", (object) entryGUID, (object) "@UserGUID", (object) guid);
          checked { ++index; }
        }
      }
      if (internalCreateNoteArgs.DiaryRecipientGUIDs != null)
      {
        queryText.PerformNonQuery("INSERT INTO tblNoteDiaries (EntryGUID, DueDate, FinalDeadline, NoteGUID) VALUES (@EntryGUID, @DueDate, @FinalDeadline, @NoteGUID)", (object) "@EntryGUID", (object) entryGUID, (object) "@DueDate", (object) internalCreateNoteArgs.DueDate, (object) "@FinalDeadline", (object) internalCreateNoteArgs.FinalDeadlineDate, (object) "@NoteGUID", (object) noteGuid);
        Guid[] diaryRecipientGuiDs = internalCreateNoteArgs.DiaryRecipientGUIDs;
        int index = 0;
        while (index < diaryRecipientGuiDs.Length)
        {
          Guid guid = diaryRecipientGuiDs[index];
          if (RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT UserID FROM tblUsers WHERE UserGUID = @qGuid", (object) "@qGuid", (object) guid)) != null)
            queryText.PerformNonQuery("INSERT INTO tblNoteRecipients ([ID], EntryGUID, UserGUID, IsDiary) VALUES (@RecipientGUID,@EntryGUID,@UserGUID,1)", (object) "@RecipientGUID", (object) Guid.NewGuid(), (object) "@EntryGUID", (object) entryGUID, (object) "@UserGUID", (object) guid);
          checked { ++index; }
        }
      }
      if (internalCreateNoteArgs.Popup)
        Note_System.Instance.NonInteractive.MarkEntryToPopup(true, entryGUID);
      return (object) noteGuid;
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
    public List<Guid> GetRecipients(Guid entryGUID)
    {
      List<Guid> recipients = new List<Guid>();
      DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("NoteSystem_GetRecipientsOnEntry", (object) "@entryGUID", (object) entryGUID);
      try
      {
        foreach (DataRow row in dataTable.Rows)
          recipients.Add((Guid) row[0]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return recipients;
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
    public List<Guid> GetDiaryRecipients(Guid entryGUID)
    {
      List<Guid> diaryRecipients = new List<Guid>();
      DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("NoteSystem_GetDiaryRecipientsOnEntry", (object) "@entryGUID", (object) entryGUID);
      try
      {
        foreach (DataRow row in dataTable.Rows)
          diaryRecipients.Add((Guid) row[0]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return diaryRecipients;
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
    public List<Guid> GetNonDiaryRecipients(Guid entryGUID)
    {
      List<Guid> nonDiaryRecipients = new List<Guid>();
      DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("NoteSystem_GetNonDiaryRecipientsOnEntry", (object) "@entryGUID", (object) entryGUID);
      try
      {
        foreach (DataRow row in dataTable.Rows)
          nonDiaryRecipients.Add((Guid) row[0]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return nonDiaryRecipients;
    }

    public DataTable DuplicateNotesByControlGuid(Guid controlGuid, Guid newControlGuid)
    {
      DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("NoteSystem_DuplicateNotesByControlGuid", (object) "@ControlGUID", (object) controlGuid, (object) "@newControlGuid", (object) newControlGuid);
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesBound);
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesUnbound);
      return dataTable;
    }

    private int SystemNoteType
    {
      get
      {
        if (this._systemNoteType == -99)
        {
          if (Database.Instance.QueryText.PerformScalarQueryInt("SELECT COUNT(*) FROM lstNoteTypes (NOLOCK) WHERE Description = 'System Generated Notes'", 0) == 0)
          {
            Database.Instance.QueryText.PerformNonQuery("INSERT INTO lstNoteTypes (Description) VALUES ('System Generated Notes')");
            Utility.Messaging.SendBroadcastMessage(BroadcastMessages.NoteTypesUpdated, (object) null);
          }
          this._systemNoteType = Database.Instance.QueryText.PerformScalarQueryInt("SELECT NoteTypeID FROM lstNoteTypes (NOLOCK) WHERE Description = 'System Generated Notes'");
        }
        return this._systemNoteType;
      }
    }

    public Guid CreateBoundNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      ISupportNoteSystem noteSupport)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, false);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BindNote(note, noteSupport);
      return note;
    }

    public Guid CreateBoundNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      ISupportNoteSystem noteSupport,
      DateTime deadlineDate,
      DateTime finalDeadline)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, false);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BindNote(note, noteSupport);
      return note;
    }

    public Guid CreateBoundNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs,
      ISupportNoteSystem noteSupport)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, false);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BindNote(note, noteSupport);
      return note;
    }

    public Guid CreateBoundNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs,
      ISupportNoteSystem noteSupport,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, false);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BeginBindNote(note, noteSupport);
      return note;
    }

    public Guid CreateBoundNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      ISupportNoteSystem noteSupport,
      bool popup)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, popup);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BindNote(note, noteSupport);
      return note;
    }

    public Guid CreateBoundNote(
      int noteType,
      string subject,
      Guid creatorGUID,
      string body,
      bool @internal,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      ISupportNoteSystem noteSupport,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), noteType, subject, creatorGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BindNote(note, noteSupport);
      return note;
    }

    public Guid CreateBoundNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs,
      ISupportNoteSystem noteSupport,
      bool popup)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, popup);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BindNote(note, noteSupport);
      return note;
    }

    public Guid CreateBoundNote(
      Note_System.NonInteractiveNoteManipulator.SystemEntity systemEntityId,
      string subject,
      string body,
      Guid[] recipientGUIDs,
      ISupportNoteSystem noteSupport,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      Guid note = this.InternalCreateNote(Guid.NewGuid(), this.SystemNoteType, subject, (int) systemEntityId, body, false, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup);
      if (note.Equals(Guid.Empty))
        throw new InvalidOperationException("CreateBoundNote note guid is empty");
      this.BeginBindNote(note, noteSupport);
      return note;
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void EditEntityDescription(Guid noteGuid, Guid entityGuid, string description)
    {
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteEntities SET EntityName = @EntityName WHERE NoteGuid = @NoteGuid AND AssociatedEntityGuid = @EntityGuid", (object) "@NoteGuid", (object) noteGuid, (object) "@EntityGuid", (object) entityGuid, (object) "@EntityName", (object) description);
    }

    public void BeginBindNote(Guid noteGUID, ISupportNoteSystem noteSupport)
    {
      ISupportNoteSystem supportNoteSystem = noteSupport != null ? noteSupport : throw new ArgumentNullException(nameof (noteSupport));
      if (supportNoteSystem.HasControlGUID)
        this.BeginBindNote(noteGUID, supportNoteSystem.FriendlyEntityName, supportNoteSystem.EntityName, supportNoteSystem.RecreateTypeName, supportNoteSystem.EntityGuid, supportNoteSystem.HasControlGUID, supportNoteSystem.ControlGUID);
      else
        this.BeginBindNote(noteGUID, supportNoteSystem.FriendlyEntityName, supportNoteSystem.EntityName, supportNoteSystem.RecreateTypeName, supportNoteSystem.EntityGuid, supportNoteSystem.HasControlGUID, Guid.Empty);
    }

    public void BeginBindNote(
      Guid noteGUID,
      string friendlyEntityName,
      string entityName,
      string recreateTypeName,
      Guid entityGUID,
      bool hasControlGuid,
      Guid controlGuid)
    {
      DataTable dataTable = Database.Instance.QueryText.PerformTableQuery("SELECT DocumentStoreGUID FROM tblDocumentAssociations (NOLOCK) WHERE AssociatedEntityGUID = @NoteGUID", (object) "@NoteGUID", (object) noteGUID);
      try
      {
        foreach (DataRow row in dataTable.Rows)
          DocumentManager.BeginBindDocument((Guid) row["DocumentStoreGUID"], true, true, entityGUID, entityName, friendlyEntityName, recreateTypeName, hasControlGuid, controlGuid);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string queryText = "INSERT INTO tblNoteEntities (ID, EntityFormName, EntityName, EntityType, NoteGUID, AssociatedEntityGUID,ControlGUID) VALUES (@EntityID, @EntityFormName, @EntityName, @EntityType, @NoteGUID, @AssociatedEntityGUID,@ControlGUID)";
      object obj = !hasControlGuid ? (object) DBNull.Value : (object) controlGuid;
      Database.Instance.QueryMultithreadedText.PerformNonQuery((Control) MDIControls.Instance.MDIParent, (object) nameof (BeginBindNote), queryText, new NonQueryMultithreadEventHandler(this.BindNote_Completed), (object) "@EntityID", (object) Guid.NewGuid(), (object) "@EntityFormName", (object) friendlyEntityName, (object) "@EntityName", (object) entityName, (object) "@EntityType", (object) recreateTypeName, (object) "@NoteGUID", (object) noteGUID, (object) "@AssociatedEntityGUID", (object) entityGUID, (object) "@ControlGUID", obj);
    }

    private void BindNote_Completed(object sender, NonQueryMultithreadEventArgs e)
    {
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesBound);
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesUnbound);
    }

    public void BindNote(Guid noteGUID, ISupportNoteSystem noteSupport)
    {
      ISupportNoteSystem supportNoteSystem = noteSupport != null ? noteSupport : throw new ArgumentNullException(nameof (noteSupport));
      this.BindNote(noteGUID, supportNoteSystem.FriendlyEntityName, supportNoteSystem.EntityName, supportNoteSystem.RecreateTypeName, supportNoteSystem.EntityGuid, supportNoteSystem.HasControlGUID, supportNoteSystem.ControlGUID);
    }

    public void BindNote(
      Guid noteGUID,
      string friendlyEntityName,
      string entityName,
      string recreateTypeName,
      Guid entityGUID,
      bool hasControlGUID,
      Guid controlGuid)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DocumentStoreGUID FROM tblDocumentAssociations (NOLOCK) WHERE AssociatedEntityGUID = @NoteGUID", new object[2]
      {
        (object) "@NoteGUID",
        (object) noteGUID
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
          DocumentManager.BeginBindDocument((Guid) row["DocumentStoreGUID"], true, true, entityGUID, entityName, friendlyEntityName, recreateTypeName, hasControlGUID, controlGuid);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblNoteEntities (ID, EntityFormName, EntityName, EntityType, NoteGUID, AssociatedEntityGUID) VALUES (@EntityID, @EntityFormName, @EntityName, @EntityType, @NoteGUID, @AssociatedEntityGUID)", new object[12]
      {
        (object) "@EntityID",
        (object) Guid.NewGuid(),
        (object) "@EntityFormName",
        (object) friendlyEntityName,
        (object) "@EntityName",
        (object) entityName,
        (object) "@EntityType",
        (object) recreateTypeName,
        (object) "@NoteGUID",
        (object) noteGUID,
        (object) "@AssociatedEntityGUID",
        (object) entityGUID
      });
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void ReassignNote(Guid noteGUID, Guid newOwnerUser)
    {
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteStore SET UserGUID = @UserGUID WHERE [ID] = @NoteGUID", (object) "@UserGUID", (object) newOwnerUser, (object) "@NoteGUID", (object) noteGUID);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    public void UnbindNote(Guid noteGUID, Guid associatedEntityGUID)
    {
      int rowsAffected = Database.Instance.QueryText.PerformNonQuery("DELETE FROM tblNoteEntities WHERE NoteGUID = @NoteGUID AND AssociatedEntityGUID = @AssociatedEntityGUID", (object) "@AssociatedEntityGUID", (object) associatedEntityGUID, (object) "@NoteGUID", (object) noteGUID);
      this.LogUnbindNote(noteGUID, associatedEntityGUID, Guid.Empty);
      this.UnbindNote_Completed((object) this, new NonQueryMultithreadEventArgs(rowsAffected, (object) noteGUID));
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    public void BeginUnbindNote(Guid noteGUID, Guid associatedEntityGUID)
    {
      Database.Instance.QueryMultithreadedText.PerformNonQuery((Control) MDIControls.Instance.MDIParent, (object) noteGUID, "DELETE FROM tblNoteEntities WHERE NoteGUID = @NoteGUID AND AssociatedEntityGUID = @AssociatedEntityGUID", new NonQueryMultithreadEventHandler(this.UnbindNote_Completed), (object) "@AssociatedEntityGUID", (object) associatedEntityGUID, (object) "@NoteGUID", (object) noteGUID);
      this.LogUnbindNote(noteGUID, associatedEntityGUID, Guid.Empty);
    }

    public void BeginUnbindNote(Guid noteGUID, Guid associatedEntityGUID, Guid controlGuid)
    {
      Database.Instance.QueryMultithreadedText.PerformNonQuery((Control) MDIControls.Instance.MDIParent, (object) noteGUID, "DELETE FROM tblNoteEntities WHERE NoteGUID = @NoteGUID AND (AssociatedEntityGUID = @AssociatedEntityGUID OR (@ControlGuid IS NOT NULL AND ControlGuid = @ControlGuid))", new NonQueryMultithreadEventHandler(this.UnbindNote_Completed), (object) "@AssociatedEntityGUID", (object) associatedEntityGUID, (object) "@NoteGUID", (object) noteGUID, (object) "@ControlGuid", Interaction.IIf(controlGuid == Guid.Empty, (object) DBNull.Value, (object) controlGuid));
      this.LogUnbindNote(noteGUID, associatedEntityGUID, controlGuid);
    }

    private void UnbindNote_Completed(object sender, NonQueryMultithreadEventArgs e)
    {
      Guid key = (Guid) e.Key;
      if (Database.Instance.QueryText.PerformScalarQueryInt("SELECT COUNT(*) FROM tblNoteEntities (NOLOCK) WHERE NoteGUID = @NoteGUID", 0, (object) "@NoteGUID", (object) key) == 0)
        this.ReassignNote(key, CurrentUser.Instance.UserGUID);
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesBound);
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesUnbound);
    }

    private void LogUnbindNote(Guid noteGuid, Guid associatedEntityGuid, Guid controlGuid)
    {
      CurrentUser.Instance.LogAction($"Disassociated Note, Subject:  {DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Subject FROM tblNoteStore WHERE ID = @NoteGuid", new object[2]
      {
        (object) "@NoteGuid",
        (object) noteGuid
      })}", Guid.Parse(Interaction.IIf(controlGuid == Guid.Empty, (object) associatedEntityGuid, (object) controlGuid).ToString()), $"NoteGuid:  {noteGuid.ToString()}");
    }

    public void AddEntryRecipients(Guid entryGuid, Guid[] recipientGuids)
    {
      Guid[] guidArray = recipientGuids;
      int index = 0;
      while (index < guidArray.Length)
      {
        Guid recipientGuid = guidArray[index];
        this.AddEntryRecipient(entryGuid, recipientGuid);
        checked { ++index; }
      }
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void AddEntryRecipient(Guid entryGuid, Guid recipientGuid)
    {
      if (Database.Instance.QueryText.PerformScalarQueryInt("SELECT COUNT(*) FROM tblNoteRecipients (NOLOCK) WHERE EntryGUID = @EntryGUID AND UserGUID = @UserGUID", (object) "@EntryGUID", (object) entryGuid, (object) "@UserGUID", (object) recipientGuid) != 0)
        return;
      Database.Instance.QueryText.PerformNonQuery("INSERT INTO tblNoteRecipients ([ID], EntryGUID, UserGUID) VALUES (@RecipientGUID,@EntryGUID,@UserGUID)", (object) "@RecipientGUID", (object) Guid.NewGuid(), (object) "@EntryGUID", (object) entryGuid, (object) "@UserGUID", (object) recipientGuid);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void ClearEntryDiaryRecipients(Guid entryGuid)
    {
      Database.Instance.QueryText.PerformNonQuery("delete from tblNoteRecipients where (EntryGUID = @EntryGUID) and (IsDiary = 1)", (object) "@EntryGuid", (object) entryGuid);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void ClearEntryRecipients(Guid entryGuid)
    {
      Database.Instance.QueryText.PerformNonQuery("delete from tblNoteRecipients where (EntryGUID = @EntryGUID) and (IsDiary = 0)", (object) "@EntryGuid", (object) entryGuid);
    }

    public List<NoteBindFailureReason> QueryRequiredNotesOnPolicy(Guid quote)
    {
      return (ObjectFactory.Instance.CreateObject(typeof (VerifyNotesOnPolicyOverride)) as VerifyNotesOnPolicyOverride).QueryRequiredNotesOnPolicy(quote);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    public void AddEntryDiaryRecipients(Guid entryGuid, Guid[] diaryRecipientGUIDs)
    {
      Guid[] guidArray = diaryRecipientGUIDs;
      int index = 0;
      while (index < guidArray.Length)
      {
        Guid diaryRecipientGUID = guidArray[index];
        this.AddEntryDiaryRecipient(entryGuid, diaryRecipientGUID);
        checked { ++index; }
      }
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void AddEntryDiaryRecipient(Guid entryGuid, Guid diaryRecipientGUID)
    {
      if (Database.Instance.QueryText.PerformScalarQueryInt("SELECT COUNT(*) FROM tblNoteRecipients (NOLOCK) WHERE IsDiary = 1 AND EntryGUID = @EntryGUID AND UserGUID = @UserGUID", (object) "@EntryGUID", (object) entryGuid, (object) "@UserGUID", (object) diaryRecipientGUID) != 0)
        return;
      Database.Instance.QueryText.PerformNonQuery("INSERT INTO tblNoteRecipients ([ID], EntryGUID, UserGUID, IsDiary) VALUES (@RecipientGUID,@EntryGUID,@UserGUID,1)", (object) "@RecipientGUID", (object) Guid.NewGuid(), (object) "@EntryGUID", (object) entryGuid, (object) "@UserGUID", (object) diaryRecipientGUID);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void ChangeNoteType(Guid noteGuid, int noteType)
    {
      Database.Instance.QueryText.PerformNonQuery("Update tblNoteStore SET Type = @Type WHERE [ID] = @NoteGuid", (object) "@Type", (object) noteType, (object) "@NoteGuid", (object) noteGuid);
    }

    public Guid AppendNoteEntry(
      Guid noteGUID,
      string body,
      bool @internal,
      Guid userGUID,
      Guid[] recipientGUIDs,
      bool popup)
    {
      return this.AppendNoteEntry(noteGUID, body, @internal, userGUID, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, popup);
    }

    public Guid AppendNoteEntry(
      Guid noteGUID,
      string body,
      bool @internal,
      Guid userGUID,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      return this.InternalAppendNoteEntry(noteGUID, body, @internal, userGUID, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup);
    }

    public Guid AppendNoteEntry(
      Guid noteGUID,
      string body,
      bool @internal,
      Guid userGUID,
      Guid[] recipientGUIDs)
    {
      return this.AppendNoteEntry(noteGUID, body, @internal, userGUID, recipientGUIDs, (Guid[]) null, DateTime.MinValue, DateTime.MinValue, false);
    }

    public Guid AppendNoteEntry(
      Guid noteGUID,
      string body,
      bool @internal,
      Guid userGUID,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline)
    {
      return this.InternalAppendNoteEntry(noteGUID, body, @internal, userGUID, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, false);
    }

    private Guid InternalAppendNoteEntry(
      Guid noteGUID,
      string body,
      bool @internal,
      Guid userGUID,
      Guid[] recipientGUIDs,
      Guid[] diaryRecipientGUIDs,
      DateTime deadlineDate,
      DateTime finalDeadline,
      bool popup)
    {
      if (recipientGUIDs == null)
        throw new ArgumentNullException("Must have at least one recipient on the note");
      object obj = Database.Instance.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(this.QuerySet_AppendNoteEntry), new object[2]
      {
        (object) new Note_System.NonInteractiveNoteManipulator.InternalCreateNoteArgs(noteGUID, -1, "", userGUID, body, @internal, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline, popup),
        (object) noteGUID
      });
      Guid guid = obj != null ? (Guid) obj : new Guid();
      if (recipientGUIDs != null && recipientGUIDs.Length > 0)
        this.NoteSystem.FireCollectionModified(NoteCollections.NotesUnbound);
      if (diaryRecipientGUIDs == null || diaryRecipientGUIDs.Length <= 0)
        return guid;
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      return guid;
    }

    private object QuerySet_AppendNoteEntry(object sender, QuerySetHandlerEventArgs e)
    {
      Guid guid1 = Guid.NewGuid();
      Note_System.NonInteractiveNoteManipulator.InternalCreateNoteArgs internalCreateNoteArgs = (Note_System.NonInteractiveNoteManipulator.InternalCreateNoteArgs) e.GetArgs()[0];
      Guid guid2 = (Guid) e.GetArgs()[1];
      DatabaseQueryText queryText = e.Database.QueryText;
      DateTime dateTime = DateAndTime.Now;
      if (SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime", false))
        dateTime = CurrentUser.ServerTime;
      queryText.PerformNonQuery("INSERT INTO dbo.tblNoteEntries ([ID], NoteGUID, Body, CreatedDate, Internal, UserGUID,EditedbyUserGUID,EditedDate, Popup) VALUES (@EntryGUID, @NoteGUID, @Body, @CreatedDate, @Internal, @UserGUID,@UserGUID,GetDate(),@Popup)", (object) "@EntryGUID", (object) guid1, (object) "@NoteGUID", (object) guid2, (object) "@Body", (object) internalCreateNoteArgs.Body, (object) "@CreatedDate", (object) dateTime, (object) "@Internal", (object) internalCreateNoteArgs.Internal, (object) "@UserGUID", (object) internalCreateNoteArgs.CreatorGUID, (object) "@Popup", (object) internalCreateNoteArgs.Popup);
      Guid[] recipientGuiDs = internalCreateNoteArgs.RecipientGUIDs;
      int index1 = 0;
      while (index1 < recipientGuiDs.Length)
      {
        Guid guid3 = recipientGuiDs[index1];
        queryText.PerformNonQuery("INSERT INTO tblNoteRecipients ([ID], EntryGUID, UserGUID) VALUES (@RecipientGUID,@EntryGUID,@UserGUID)", (object) "@RecipientGUID", (object) Guid.NewGuid(), (object) "@EntryGUID", (object) guid1, (object) "@UserGUID", (object) guid3);
        checked { ++index1; }
      }
      if (internalCreateNoteArgs.DiaryRecipientGUIDs != null)
      {
        queryText.PerformNonQuery("INSERT INTO tblNoteDiaries (EntryGUID, DueDate, FinalDeadline, NoteGUID) VALUES (@EntryGUID, @DueDate, @FinalDeadline, @NoteGUID)", (object) "@EntryGUID", (object) guid1, (object) "@DueDate", (object) internalCreateNoteArgs.DueDate, (object) "@FinalDeadline", (object) internalCreateNoteArgs.FinalDeadlineDate, (object) "@NoteGUID", (object) guid2);
        Guid[] guidArray1;
        if (internalCreateNoteArgs.DiaryRecipientGUIDs.Length == 0)
          guidArray1 = new Guid[1]
          {
            internalCreateNoteArgs.CreatorGUID
          };
        else
          guidArray1 = internalCreateNoteArgs.DiaryRecipientGUIDs;
        Guid[] guidArray2 = guidArray1;
        int index2 = 0;
        while (index2 < guidArray2.Length)
        {
          Guid guid4 = guidArray2[index2];
          queryText.PerformNonQuery("INSERT INTO tblNoteRecipients ([ID], EntryGUID, UserGUID, IsDiary) VALUES (@RecipientGUID,@EntryGUID,@UserGUID,1)", (object) "@RecipientGUID", (object) Guid.NewGuid(), (object) "@EntryGUID", (object) guid1, (object) "@UserGUID", (object) guid4);
          checked { ++index2; }
        }
      }
      return (object) guid1;
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    public void BeginDeleteNote(Guid noteGUID)
    {
      if (Database.Instance.QueryText.PerformScalarQueryInt("SELECT COUNT(*) FROM tblNoteEntities (NOLOCK) WHERE NoteGUID = @NoteGUID", (object) "@NoteGUID", (object) noteGUID) > 0)
        return;
      new Note_System.NonInteractiveNoteManipulator.DeleteNoteThread(noteGUID, new EventHandler(this.DeleteNote_Completed)).StartThread();
    }

    private void DeleteNote_Completed(object sender, EventArgs e)
    {
      this.NoteSystem.FireCollectionModified(NoteCollections.All);
      this.NoteSystem.FireNoteDeleted(((Note_System.NonInteractiveNoteManipulator.DeleteNoteThread) sender).DeletedNoteGUID);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    public void MarkEntryToPopup(bool popup, Guid entryGUID)
    {
      this.MarkEntryToPopupInternal(popup, entryGUID, false);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    public void BeginMarkEntryToPopup(bool popup, Guid entryGUID)
    {
      this.MarkEntryToPopupInternal(popup, entryGUID, true);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    private void MarkEntryToPopupInternal(bool popup, Guid entryGUID, bool useThread)
    {
      string queryText = "UPDATE tblNoteEntries SET Popup = @popup WHERE [ID] = @EntryGUID";
      if (useThread)
        Database.Instance.QueryMultithreadedText.PerformNonQuery(queryText, (object) "@popup", (object) popup, (object) "@EntryGUID", (object) entryGUID);
      else
        Database.Instance.QueryText.PerformNonQuery(queryText, (object) "@popup", (object) popup, (object) "@EntryGUID", (object) entryGUID);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    public void MarkEntryAsInternal(bool @internal, Guid entryGUID)
    {
      this.MarkEntryInternal(@internal, entryGUID, false);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
    public void BeginMarkEntryAsInternal(bool @internal, Guid entryGUID)
    {
      this.MarkEntryInternal(@internal, entryGUID, true);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    private void MarkEntryInternal(bool @internal, Guid entryGUID, bool useThread)
    {
      string queryText = "UPDATE tblNoteEntries SET Internal = @Internal WHERE [ID] = @EntryGUID";
      if (useThread)
        Database.Instance.QueryMultithreadedText.PerformNonQuery(queryText, (object) "@Internal", (object) @internal, (object) "@EntryGUID", (object) entryGUID);
      else
        Database.Instance.QueryText.PerformNonQuery(queryText, (object) "@Internal", (object) @internal, (object) "@EntryGUID", (object) entryGUID);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    public void CompleteDiaryEntryForAllAdministrative(
      Guid diaryEntryGUID,
      Guid userGuid,
      string userName)
    {
      DataTable dataTable1 = Database.Instance.QueryText.PerformTableQuery("SELECT UserGUID FROM tblNoteRecipients (NOLOCK) WHERE IsDiary = 1 AND EntryGuid = @EntryGUID AND CompletedDate IS NULL AND UserGuid <> @UserGuid", (object) "@EntryGUID", (object) diaryEntryGUID, (object) "@UserGuid", (object) userGuid);
      DataTable dataTable2 = DefaultDatabase.ExecuteDataTable("NoteSystem_FetchQuoteInfoOnNotes", new object[2]
      {
        (object) "@EntityGuid",
        (object) diaryEntryGUID
      });
      string str1 = string.Empty;
      string empty = string.Empty;
      try
      {
        foreach (DataRow row in dataTable2.Rows)
        {
          int num = (int) row["Controlno"];
          str1 = (string) row["Body"];
          if (num != 0)
          {
            string str2 = $"The diary was was completed for control number:  {Conversions.ToString(num)} .";
            str1 = $"{str1} {str2}";
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      List<Guid> guidList = new List<Guid>();
      try
      {
        foreach (DataRow row in dataTable1.Rows)
          guidList.Add((Guid) row["UserGUID"]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (guidList.Count > 0)
        this.CreateNote(Note_System.NonInteractiveNoteManipulator.SystemEntity.IMS, $"{userName} has completed the entire diary", $"Diary Text: {str1}", guidList.ToArray());
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteRecipients SET CompletedDate = GETDATE(), IsRead = 1 WHERE IsDiary = 1 AND EntryGUID = @EntryGUID", (object) "@EntryGUID", (object) diaryEntryGUID);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesBound);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.NoteEntriesOpen);
    }

    internal static XmlDocument BuildDiaryRecipientChangeSetXml(
      dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryDataTable diaryRecipientCompletionChanges)
    {
      XmlDocument xmlDocument = new XmlDocument();
      XmlNode node1 = xmlDocument.CreateNode(XmlNodeType.Element, "DiaryRecipientChangeSet", "");
      xmlDocument.AppendChild(node1);
      try
      {
        foreach (dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow completionChange in (TypedTableBase<dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow>) diaryRecipientCompletionChanges)
        {
          XmlNode node2 = xmlDocument.CreateNode(XmlNodeType.Element, "DiaryRecipientChange", "");
          XmlAttribute attribute1 = xmlDocument.CreateAttribute("UserGuid");
          attribute1.Value = completionChange.userguid.ToString();
          XmlAttribute attribute2 = xmlDocument.CreateAttribute("CompletedDate");
          attribute2.Value = completionChange.CompletedDate.ToString();
          XmlAttribute attribute3 = xmlDocument.CreateAttribute("Completed");
          attribute3.Value = (string) Interaction.IIf(completionChange.Completed, (object) "1", (object) "0");
          node2.Attributes.Append(attribute1);
          node2.Attributes.Append(attribute2);
          node2.Attributes.Append(attribute3);
          node1.AppendChild(node2);
        }
      }
      finally
      {
        IEnumerator<dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow> enumerator;
        enumerator?.Dispose();
      }
      return xmlDocument;
    }

    public void SendDiaryChangeNotification(Guid diaryEntryGuid, Guid userGuid, bool completed)
    {
      dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryDataTable diaryRecipientCompletionChanges = new dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryDataTable();
      diaryRecipientCompletionChanges.AddNoteSystem_GetDiaryRecipientsStatusOnEntryRow(userGuid, DateAndTime.Now, "", completed);
      XmlDocument diaryRecipientChangeSetXml = Note_System.NonInteractiveNoteManipulator.BuildDiaryRecipientChangeSetXml(diaryRecipientCompletionChanges);
      this.InternalSendDiaryChangeNotification(diaryEntryGuid, CurrentUser.Instance.UserGUID, diaryRecipientChangeSetXml);
    }

    public void SendDiaryChangeNotification(
      Guid diaryEntryGuid,
      XmlDocument diaryRecipientChangeSetXml)
    {
      this.InternalSendDiaryChangeNotification(diaryEntryGuid, CurrentUser.Instance.UserGUID, diaryRecipientChangeSetXml);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    private void InternalSendDiaryChangeNotification(
      Guid diaryEntryGuid,
      Guid changedByUserGuid,
      XmlDocument diaryRecipientChangeSetXml)
    {
      Database.Instance.QuerySP.PerformNonQuery("NoteSystem_NotifyDiaryRecipientsOnDiaryStatusChange", (object) "@EntryGUID", (object) diaryEntryGuid, (object) "@changedByUserGuid", (object) changedByUserGuid, (object) "@diaryRecipientChangeSetXml", (object) diaryRecipientChangeSetXml.OuterXml);
    }

    public void BeginCompleteDiaryEntry(Guid diaryEntryGUID, Guid userGUID)
    {
      this.InternalCompleteDiary(diaryEntryGUID, userGUID, true, true);
    }

    public void CompleteDiaryEntry(Guid diaryEntryGUID, Guid userGUID)
    {
      this.InternalCompleteDiary(diaryEntryGUID, userGUID, false, true);
    }

    public void BeginCompleteDiaryEntry(Guid diaryEntryGUID, Guid userGUID, bool completed)
    {
      this.InternalCompleteDiary(diaryEntryGUID, userGUID, true, completed);
    }

    public void CompleteDiaryEntry(Guid diaryEntryGUID, Guid userGUID, bool completed)
    {
      this.InternalCompleteDiary(diaryEntryGUID, userGUID, false, completed);
    }

    private void InternalCompleteDiary(
      Guid diaryEntryGUID,
      Guid userGUID,
      bool useThread,
      bool completed)
    {
      dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryDataTable diaryRecipientCompletionChanges = new dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryDataTable();
      DateTime CompletedDate = DateAndTime.Now;
      if (SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime", false))
        CompletedDate = CurrentUser.ServerTime;
      dsMultiRecipientDiary.NoteSystem_GetDiaryRecipientsStatusOnEntryRow statusOnEntryRow = diaryRecipientCompletionChanges.AddNoteSystem_GetDiaryRecipientsStatusOnEntryRow(userGUID, CompletedDate, "", true);
      if (!completed)
        statusOnEntryRow.Completed = false;
      XmlDocument diaryRecipientChangeSetXml = Note_System.NonInteractiveNoteManipulator.BuildDiaryRecipientChangeSetXml(diaryRecipientCompletionChanges);
      if (useThread)
        this.BeginCompleteDiarySet(diaryEntryGUID, diaryRecipientChangeSetXml);
      else
        this.CompleteDiarySet(diaryEntryGUID, diaryRecipientChangeSetXml);
    }

    [SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", MessageId = "System.Xml.XmlNode")]
    public void CompleteDiarySet(Guid diaryEntryGuid, XmlDocument diaryRecipientChangeSetXml)
    {
      this.InternalCompleteDiarySet(diaryEntryGuid, diaryRecipientChangeSetXml, false);
    }

    [SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", MessageId = "System.Xml.XmlNode")]
    public void BeginCompleteDiarySet(Guid diaryEntryGuid, XmlDocument diaryRecipientChangeSetXml)
    {
      this.InternalCompleteDiarySet(diaryEntryGuid, diaryRecipientChangeSetXml, true);
    }

    private void InternalCompleteDiarySet(
      Guid diaryEntryGuid,
      XmlDocument diaryRecipientChangeSetXml,
      bool useThread)
    {
      if (useThread)
      {
        Database.Instance.QueryMultithreadedSP.PerformNonQuery((Control) MDIControls.Instance.MDIParent, (object) nameof (InternalCompleteDiarySet), "NoteSystem_UpdateDiaryRecipientsStatusOnEntry", new NonQueryMultithreadEventHandler(this.CompletedDiary_Completed), (object) "@EntryGUID", (object) diaryEntryGuid, (object) "@diaryRecipientChangeSetXml", (object) diaryRecipientChangeSetXml.OuterXml);
      }
      else
      {
        Database.Instance.QuerySP.PerformNonQuery("NoteSystem_UpdateDiaryRecipientsStatusOnEntry", (object) "@EntryGUID", (object) diaryEntryGuid, (object) "@diaryRecipientChangeSetXml", (object) diaryRecipientChangeSetXml.OuterXml);
        this.CompletedDiary_Completed((object) this, (NonQueryMultithreadEventArgs) null);
      }
      Utility.Messaging.SendBroadcastMessage(BroadcastMessages.DiaryCompletionStatusChanged, (object) new DiaryCompletionStatusChangedEventArgs(diaryEntryGuid, diaryRecipientChangeSetXml));
    }

    private void CompletedDiary_Completed(object sender, NonQueryMultithreadEventArgs e)
    {
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesBound);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.NoteEntriesOpen);
    }

    public void MarkEntireNoteRead(Guid noteGuid, Guid userGuid)
    {
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteRecipients SET IsRead = 1 WHERE UserGUID = @UserGUID AND EntryGUID IN (SELECT [ID] FROM tblNoteEntries (NOLOCK) WHERE NoteGuid = @NoteGuid)", (object) "@NoteGUID", (object) noteGuid, (object) "@UserGUID", (object) userGuid);
      this.NoteRead_Completed((object) this, (NonQueryMultithreadEventArgs) null);
    }

    public void BeginMarkNoteRead(Guid entryGUID, Guid userGUID)
    {
      this.InternalMarkNoteRead(entryGUID, userGUID, true);
    }

    public void MarkNoteRead(Guid entryGUID, Guid userGUID)
    {
      this.InternalMarkNoteRead(entryGUID, userGUID, false);
    }

    public void BeginMarkNoteRead(Guid entryGUID, Guid userGUID, bool read)
    {
      this.InternalMarkNoteRead(entryGUID, userGUID, true, read);
    }

    public void MarkNoteRead(Guid entryGUID, Guid userGUID, bool read)
    {
      this.InternalMarkNoteRead(entryGUID, userGUID, false, read);
    }

    private void InternalMarkNoteRead(Guid entryGUID, Guid userGUID, bool useThread)
    {
      this.InternalMarkNoteRead(entryGUID, userGUID, useThread, true);
    }

    private void InternalMarkNoteRead(Guid entryGUID, Guid userGUID, bool useThread, bool read)
    {
      string queryText = !read ? "UPDATE tblNoteRecipients SET IsRead = 0 WHERE EntryGUID = @EntryGUID AND UserGUID = @UserGUID" : "UPDATE tblNoteRecipients SET IsRead = 1 WHERE EntryGUID = @EntryGUID AND UserGUID = @UserGUID";
      if (useThread)
      {
        Database.Instance.QueryMultithreadedText.PerformNonQuery((Control) MDIControls.Instance.MDIParent, (object) nameof (InternalMarkNoteRead), queryText, new NonQueryMultithreadEventHandler(this.NoteRead_Completed), (object) "@EntryGUID", (object) entryGUID, (object) "@UserGUID", (object) userGUID);
      }
      else
      {
        Database.Instance.QueryText.PerformNonQuery(queryText, (object) "@EntryGUID", (object) entryGUID, (object) "@UserGUID", (object) userGUID);
        this.NoteRead_Completed((object) this, (NonQueryMultithreadEventArgs) null);
      }
    }

    private void NoteRead_Completed(object sender, NonQueryMultithreadEventArgs e)
    {
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.NoteEntriesOpen);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void UpdateDiaryInfo(
      Guid entryGUID,
      Guid noteGuid,
      DateTime newDueDate,
      DateTime newFinalDate)
    {
      Database.Instance.QueryText.PerformNonQuery("update tblNoteDiaries set DueDate = @DueDate, FinalDeadline = @FinalDeadline where EntryGUID = @EntryGUID and NoteGUID = @NoteGUID", (object) "@DueDate", (object) newDueDate, (object) "@FinalDeadline", (object) newFinalDate, (object) "@EntryGUID", (object) entryGUID, (object) "@NoteGUID", (object) noteGuid);
    }

    private object QuerySet_UpdateNoteEntry(object sender, QuerySetHandlerEventArgs e)
    {
      Guid guid1 = (Guid) e.GetArgs()[0];
      string str = e.GetArgs()[1].ToString();
      Guid guid2 = Guid.NewGuid();
      Database.Instance.QueryText.PerformNonQuery("INSERT INTO tblNoteEntries SELECT @CopiedEntryGUID, NoteGUID,Body,CreatedDate,Internal,UserGUID,@EditParent, EditedbyUserGUID, EditedDate, SystemEntityID, Popup, BodyAbbreviated FROM tblNoteEntries WHERE [ID] = @EditParent", (object) "@CopiedEntryGUID", (object) guid2, (object) "@EditParent", (object) guid1);
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteEntries SET Body = @Body, EditedbyUserGUID = @EditedbyUserGUID, EditedDate = GetDate() WHERE [ID] = @EntryGUID", (object) "@Body", (object) str, (object) "@EditedbyUserGUID", (object) CurrentUser.Instance.UserGUID, (object) "@EntryGUID", (object) guid1);
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteEntries SET EditParent = @EditParent WHERE EditParent = @EntryGUID", (object) "@EntryGUID", (object) guid2, (object) "@EditParent", (object) guid1);
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteEntries SET EditParent = @EditParent WHERE EditParent = @EntryGUID AND [ID] != @EditParent", (object) "@EntryGUID", (object) guid1, (object) "@EditParent", (object) guid2);
      return (object) null;
    }

    public void UpdateNoteEntry(Guid originalEntryGUID, string newBody)
    {
      this.UpdateNoteEntry(originalEntryGUID, newBody, false);
    }

    public void UpdateNoteEntry(Guid originalEntryGUID, string newBody, bool popup)
    {
      Database.Instance.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(this.QuerySet_UpdateNoteEntry), new object[2]
      {
        (object) originalEntryGUID,
        (object) newBody
      });
      this.MarkEntryToPopup(popup, originalEntryGUID);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.NoteEntriesOpen);
    }

    public void UpdateNote(Guid noteGUID, string subject, int type)
    {
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteStore SET Type = @Type, Subject = @Subject WHERE [id] = @NoteGUID", (object) "@Type", (object) type, (object) "@Subject", (object) subject, (object) "@NoteGUID", (object) noteGUID);
      this.NoteSystem.FireCollectionModified(NoteCollections.All);
    }

    public void UpdateNote(Guid noteGUID, string subject)
    {
      Database.Instance.QueryText.PerformNonQuery("UPDATE tblNoteStore SET Subject = @Subject WHERE [id] = @NoteGUID", (object) "@Subject", (object) subject, (object) "@NoteGUID", (object) noteGUID);
      this.NoteSystem.FireCollectionModified(NoteCollections.All);
    }

    public void BeginUpdateNote(Guid noteGUID, string subject, int type)
    {
      Database.Instance.QueryMultithreadedText.PerformNonQuery((Control) MDIControls.Instance.MDIParent, (object) nameof (BeginUpdateNote), "UPDATE tblNoteStore SET Type = @Type, Subject = @Subject WHERE [id] = @NoteGUID", new NonQueryMultithreadEventHandler(this.UpdateNote_QueryCompleted), (object) "@Type", (object) type, (object) "@Subject", (object) subject, (object) "@NoteGUID", (object) noteGUID);
    }

    public void BeginUpdateNote(Guid noteGUID, string subject)
    {
      Database.Instance.QueryMultithreadedText.PerformNonQuery((Control) MDIControls.Instance.MDIParent, (object) nameof (BeginUpdateNote), "UPDATE tblNoteStore SET Subject = @Subject WHERE [id] = @NoteGUID", new NonQueryMultithreadEventHandler(this.UpdateNote_QueryCompleted), (object) "@Subject", (object) subject, (object) "@NoteGUID", (object) noteGUID);
    }

    private void UpdateNote_QueryCompleted(object sender, NonQueryMultithreadEventArgs e)
    {
      this.NoteSystem.FireCollectionModified(NoteCollections.All);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => base.Equals(RuntimeHelpers.GetObjectValue(obj));

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public int NotesOnEntityCount(Guid entityGuid)
    {
      return Database.Instance.QueryText.PerformScalarQueryInt("SELECT COUNT(*) AS NoteCount FROM tblNoteEntities WHERE AssociatedEntityGUID = @EntityGUID", 0, (object) "@EntityGUID", (object) entityGuid);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void BeginPrintNote(Guid noteGUID)
    {
      new Note_System.NonInteractiveNoteManipulator.PrintNote(noteGUID).StartThread();
    }

    public string PdfSave(Guid noteGuid)
    {
      string fileName = $"{MGATempFolder.CreateTempSubdirectory()}{"ImsNote.pdf"}";
      this.PdfSave(noteGuid, fileName);
      return fileName;
    }

    public void PdfSave(Guid noteGuid, string fileName)
    {
      using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
      {
        using (PdfExport pdfExport = new PdfExport())
        {
          using (SectionReport noteReport = Note_System.NonInteractiveNoteManipulator.PrintNote.CreateNoteReport(noteGuid))
          {
            noteReport.Run();
            pdfExport.Export(noteReport.Document, (Stream) fileStream);
          }
        }
      }
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void BeginPrintEntityNotes(Guid entityGUID, Guid controlGuid, string entityName)
    {
      new Note_System.NonInteractiveNoteManipulator.PrintEntityNotes(entityGUID, controlGuid, entityName).StartThread();
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
    public static Guid NoteGUIDFromEntryGUID(Guid entryGUID)
    {
      return Database.Instance.QueryText.PerformScalarQueryGuid("SELECT NoteGUID FROM tblNoteEntries (NOLOCK) WHERE [ID] = @EntryGUID", (object) "@EntryGUID", (object) entryGUID);
    }

    private sealed class FindNotesByEntityThreadArgs
    {
      private readonly NoteSupportCache _noteSupportCache;
      private readonly Note_System.NotesFoundEventHandler _notesFound;

      public FindNotesByEntityThreadArgs(
        NoteSupportCache noteSupportCache,
        Note_System.NotesFoundEventHandler notesFound)
      {
        this._noteSupportCache = noteSupportCache;
        this._notesFound = notesFound;
      }

      public Note_System.NotesFoundEventHandler NotesFound => this._notesFound;

      public NoteSupportCache NoteSupportCache => this._noteSupportCache;
    }

    [SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    public enum SystemEntity
    {
      [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")] IMS = 1,
    }

    private sealed class InternalCreateNoteArgs
    {
      private int _noteType;
      private string _subject;
      private Guid _creatorGUID;
      private string _body;
      private Guid[] _recipientGUID;
      private Guid[] _diaryRecipientGUIDs;
      private bool _internal;
      private DateTime _dueDate;
      private DateTime _finalDeadline;
      private int _systemEntityID;
      private Guid _noteGUID;
      private bool _popup;

      public InternalCreateNoteArgs(
        Guid noteGUID,
        int noteType,
        string subject,
        Guid creatorGUID,
        string body,
        bool @internal,
        Guid[] recipientGUIDs,
        Guid[] diaryRecipientGUIDs,
        DateTime deadLineDate,
        DateTime finalDeadline,
        bool popup)
      {
        this._systemEntityID = -1;
        this._noteType = noteType;
        this._subject = subject;
        this._creatorGUID = creatorGUID;
        this._body = body;
        this._recipientGUID = recipientGUIDs;
        this._diaryRecipientGUIDs = diaryRecipientGUIDs;
        this._internal = @internal;
        this._dueDate = deadLineDate;
        this._finalDeadline = finalDeadline;
        this._noteGUID = noteGUID;
        this._popup = popup;
      }

      public InternalCreateNoteArgs(
        Guid noteGUID,
        int noteType,
        string subject,
        int systemEntityID,
        string body,
        bool @internal,
        Guid[] recipientGUIDs,
        Guid[] diaryRecipientGUIDs,
        DateTime deadLineDate,
        DateTime finalDeadline,
        bool popup)
      {
        this._systemEntityID = -1;
        this._noteType = noteType;
        this._subject = subject;
        this._creatorGUID = this.CreatorGUID;
        this._body = body;
        this._recipientGUID = recipientGUIDs;
        this._diaryRecipientGUIDs = diaryRecipientGUIDs;
        this._internal = @internal;
        this._dueDate = deadLineDate;
        this._finalDeadline = finalDeadline;
        this._systemEntityID = systemEntityID;
        this._noteGUID = noteGUID;
        this._popup = popup;
      }

      public bool Popup => this._popup;

      public int NoteType => this._noteType;

      public string Subject => this._subject;

      public Guid CreatorGUID => this._creatorGUID;

      public string Body => this._body;

      public Guid[] RecipientGUIDs => this._recipientGUID;

      public Guid[] DiaryRecipientGUIDs => this._diaryRecipientGUIDs;

      public bool Internal => this._internal;

      public DateTime DueDate => this._dueDate;

      public DateTime FinalDeadlineDate => this._finalDeadline;

      public bool IsSystemNote => this._systemEntityID != -1;

      public int SystemEntityID => this._systemEntityID;

      public Guid NoteGUID => this._noteGUID;
    }

    private sealed class DeleteNoteThread : QueryThread
    {
      private Guid _noteGUID;
      private EventHandler _deleteCompleted;

      public DeleteNoteThread(Guid noteGUID, EventHandler deleteCompleted)
        : base((Control) MDIControls.Instance.MDIParent, (object) nameof (DeleteNoteThread), string.Empty)
      {
        this._noteGUID = noteGUID;
        this._deleteCompleted = deleteCompleted;
      }

      public Guid DeletedNoteGUID => this._noteGUID;

      private object QuerySet_DeleteNote(object sender, QuerySetHandlerEventArgs e)
      {
        e.Database.QueryText.PerformNonQuery("DELETE FROM tblNoteRecipients WHERE EntryGUID IN (SELECT [ID] FROM tblNoteEntries (NOLOCK) WHERE NoteGUID = @NoteGUID)", (object) "@NoteGUID", (object) this._noteGUID);
        e.Database.QueryText.PerformNonQuery("DELETE FROM tblNoteDiaries WHERE NoteGUID = @NoteGUID", (object) "@NoteGUID", (object) this._noteGUID);
        e.Database.QueryText.PerformNonQuery("DELETE FROM tblNoteEntries WHERE NoteGUID = @NoteGUID", (object) "@NoteGUID", (object) this._noteGUID);
        e.Database.QueryText.PerformNonQuery("DELETE FROM tblNoteStore WHERE [ID] = @NoteGUID", (object) "@NoteGUID", (object) this._noteGUID);
        return (object) null;
      }

      protected override void ThreadCompletedUI()
      {
        this._deleteCompleted((object) this, EventArgs.Empty);
      }

      protected override void ThreadProcBG()
      {
        this.DB.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(this.QuerySet_DeleteNote));
      }
    }

    private sealed class PrintNote : QueryThread
    {
      private Guid _noteGUID;

      public PrintNote(Guid noteGUID)
        : base((Control) MDIControls.Instance.MDIParent, (object) noteGUID.ToString(), string.Empty)
      {
        this._noteGUID = noteGUID;
      }

      protected override void ThreadCompletedUI()
      {
        int num = (int) MessageBox.Show("Completed printing note", "Note Print Completed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }

      internal static SectionReport CreateNoteReport(Guid noteGuid)
      {
        DataTable dataTable1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT dbo.tblNoteStore.Subject, dbo.lstNoteTypes.Description, dbo.tblNoteStore.CreatedDate, dbo.tblUsers.UserName, dbo.tblNoteStore.ID AS NoteGUID FROM dbo.tblNoteStore (NOLOCK) INNER JOIN dbo.lstNoteTypes (NOLOCK) ON dbo.tblNoteStore.Type = dbo.lstNoteTypes.NoteTypeID INNER JOIN dbo.tblUsers (NOLOCK) ON dbo.tblNoteStore.UserGUID = dbo.tblUsers.UserGUID WHERE (dbo.tblNoteStore.ID = @NoteGUID)", new object[2]
        {
          (object) "@NoteGUID",
          (object) noteGuid
        });
        SectionReport noteReport;
        if (dataTable1.Rows.Count > 0)
        {
          DataRow row1 = dataTable1.Rows[0];
          string str1 = Database.IsNull(RuntimeHelpers.GetObjectValue(row1["Subject"]), "No Subject");
          string str2 = Database.IsNull(RuntimeHelpers.GetObjectValue(row1["Description"]), "Unknown Type");
          DateTime dateTime = Database.IsNull(RuntimeHelpers.GetObjectValue(row1["CreatedDate"]), DateAndTime.Now);
          string str3 = Database.IsNull(RuntimeHelpers.GetObjectValue(row1["UserName"]), "Unknown User");
          DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Body FROM dbo.tblNoteEntries (NOLOCK) WHERE (EditParent IS NULL) AND (NoteGUID = @NoteGUID) ORDER BY CreatedDate", new object[2]
          {
            (object) "@NoteGUID",
            (object) noteGuid
          });
          StringBuilder stringBuilder = new StringBuilder();
          try
          {
            foreach (DataRow row2 in dataTable2.Rows)
              stringBuilder.Append(Database.IsNull(RuntimeHelpers.GetObjectValue(row2["Body"]), string.Empty));
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          string str4 = stringBuilder.ToString();
          noteReport = Utility.Reporting.QueryReport("rptNoteReport", (object) dateTime, (object) str1, (object) str2, (object) str4, (object) str3, (object) "", (object) "");
        }
        else
          noteReport = (SectionReport) null;
        return noteReport;
      }

      protected override void ThreadProcBG()
      {
        SectionReport noteReport = Note_System.NonInteractiveNoteManipulator.PrintNote.CreateNoteReport(this._noteGUID);
        if (noteReport == null)
          return;
        try
        {
          noteReport.Run();
          Utility.Reporting.PrintReport(noteReport);
        }
        finally
        {
          noteReport.Dispose();
        }
      }
    }

    private sealed class PrintEntityNotes : QueryThread
    {
      private Guid _entityGUID;
      private Guid _controlGuid;

      public PrintEntityNotes(Guid entityGUID, Guid controlGuid, string entityName)
        : base((Control) MDIControls.Instance.MDIParent, (object) entityName, string.Empty)
      {
        this._entityGUID = entityGUID;
        this._controlGuid = controlGuid;
      }

      protected override void ThreadCompletedUI()
      {
        int num = (int) MessageBox.Show("Completed printing notes for " + Conversions.ToString(this.Key), "Note Print Completed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }

      protected override void ThreadProcBG()
      {
        DataTable dataTable = this.DB.QuerySP.PerformTableQuery("NoteSystem_FetchNotesOnEntity", (object) "@EntityGuid", (object) this._entityGUID, (object) "@ControlGuid", (object) this._controlGuid);
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            string str1 = Database.IsNull(RuntimeHelpers.GetObjectValue(row["Subject"]), "No Subject");
            string str2 = Database.IsNull(RuntimeHelpers.GetObjectValue(row["Description"]), "Unknown Type");
            string str3 = Database.IsNull(RuntimeHelpers.GetObjectValue(row["Body"]), string.Empty);
            DateTime dateTime = Database.IsNull(RuntimeHelpers.GetObjectValue(row["CreatedDate"]), DateAndTime.Now);
            string str4 = Database.IsNull(RuntimeHelpers.GetObjectValue(row["UserName"]), "Unknown User");
            Database.IsNull(RuntimeHelpers.GetObjectValue(row["NoteGUID"]), Guid.Empty);
            SectionReport rpt = Utility.Reporting.QueryReport("rptNoteReport", (object) dateTime, (object) str1, (object) str2, (object) str3, (object) str4, (object) "", (object) "");
            try
            {
              rpt.Run();
              Utility.Reporting.PrintReport(rpt);
            }
            finally
            {
              rpt.Dispose();
            }
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
  }

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SecureResource("{AE6E189D-AE09-4a2d-8107-E900EF75FB28}", "Show IMS Tasks Screen", "Controls if the IMS Task Screen is shown", "Note System")]
  public class UIInteractiveNoteManipulator
  {
    public const string SecurityIdAllowTodayScreenView = "{AE6E189D-AE09-4a2d-8107-E900EF75FB28}";
    public static readonly Guid EventIdAutoInitializeNoteType = Guid.NewGuid();
    private Note_System _noteSystem;
    private Hashtable _popupNotesSessionList;

    public UIInteractiveNoteManipulator(Note_System noteSystem)
    {
      this._noteSystem = (Note_System) null;
      this._popupNotesSessionList = new Hashtable();
      this._noteSystem = noteSystem;
    }

    protected Note_System NoteSystem => this._noteSystem;

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void CreateNote() => FormSettings.ShowForm(typeof (frmNote));

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public Form CreateBoundNote(ISupportNoteSystem noteSupport)
    {
      if (noteSupport == null)
        throw new ArgumentNullException(nameof (noteSupport));
      Form boundNote;
      if (noteSupport.CanCreateNewNote)
      {
        boundNote = FormSettings.ShowForm(typeof (frmNote), (object) noteSupport);
      }
      else
      {
        int num = (int) MessageBox.Show("This item does not support bound notes", "Cannot create a bound note on this item", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        boundNote = (Form) null;
      }
      return boundNote;
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void CreateQuickNote() => FormSettings.ShowForm(typeof (TabNotePanelQuickNote));

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public void ViewTodayScreen()
    {
      if (!SecurityManager.Instance.AssertPermission("{AE6E189D-AE09-4a2d-8107-E900EF75FB28}"))
        return;
      MDIControls.Instance.ActivateForm(typeof (frmToday), true);
    }

    private void PopupNotesOwnerFormClosing(object sender, FormClosingEventArgs e)
    {
      ((Form) sender).FormClosing -= new FormClosingEventHandler(this.PopupNotesOwnerFormClosing);
      if (this._popupNotesSessionList.ContainsKey(RuntimeHelpers.GetObjectValue(sender)))
      {
        this._popupNotesSessionList.Remove(RuntimeHelpers.GetObjectValue(sender));
      }
      else
      {
        InvalidOperationException operationException = new InvalidOperationException("popup owner not in list");
        operationException.Data.Add((object) "Sender", (object) sender.ToString());
        operationException.Data.Add((object) "Sender Type", (object) sender.GetType());
        throw operationException;
      }
    }

    public void ViewPopupNotes(Guid entityGuid, Form ownerForm)
    {
      this.ViewPopupNotes(Guid.Empty, entityGuid, ownerForm);
    }

    public void ViewPopupNotes(Guid controlGuid, Guid entityGuid, Form ownerForm)
    {
      if (ownerForm == null)
        throw new ArgumentNullException(nameof (ownerForm));
      if (!(ownerForm is ISupportNoteSystem supportNoteSystem))
        throw new InvalidOperationException("ownerform must implement ISupportNoteSystem");
      if (!supportNoteSystem.CanReCreateEntity)
        return;
      string str = controlGuid.ToString() + entityGuid.ToString();
      if (!this._popupNotesSessionList.ContainsValue((object) str))
        ObjectFactory.QueryInterface<IPopupNoteForm>(RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(typeof (frmPopupNotes), (object) controlGuid, (object) entityGuid))).ShowPopup();
      if (this._popupNotesSessionList.Contains((object) ownerForm))
        return;
      this._popupNotesSessionList.Add((object) ownerForm, (object) str);
      ownerForm.FormClosing += new FormClosingEventHandler(this.PopupNotesOwnerFormClosing);
    }

    public void ViewNote(Guid noteGUID, Guid[] documentGuids, ISupportDocumentSystem docSupport)
    {
      FormSettings.ShowForm(typeof (frmNote), (object) noteGUID, (object) documentGuids, (object) docSupport);
    }

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
    public void ViewNote(Guid noteGUID) => this.ViewNote(noteGUID, false);

    public void ViewNote(Guid noteGUID, bool startInEditMode)
    {
      FormSettings.ShowForm(typeof (frmNote), (object) noteGUID, (object) startInEditMode);
    }

    public void ViewNote(
      Guid noteGUID,
      Guid entryGUID,
      bool markRead,
      ISupportNoteSystem noteSupport)
    {
      if (markRead)
        this.NoteSystem.NonInteractive.MarkNoteRead(entryGUID, CurrentUser.Instance.UserGUID);
      FormSettings.ShowForm(typeof (frmNote), (object) noteGUID, (object) entryGUID, (object) noteSupport);
    }

    public void ViewNote(Guid noteGUID, ISupportNoteSystem noteSupport)
    {
      FormSettings.ShowForm(typeof (frmNote), (object) noteGUID, (object) noteSupport);
    }

    public void ViewNote(Guid noteGUID, Guid entryGUID, ISupportNoteSystem noteSupport)
    {
      this.ViewNote(noteGUID, entryGUID, true, noteSupport);
    }

    public List<NoteBindFailureReason> VerifyRequiredNotesOnPolicy(
      Guid quote,
      NoteBindRequirement requirement)
    {
      try
      {
        foreach (NoteBindFailureReason policyForRequiredNote in this.CheckPolicyForRequiredNotes(quote, requirement))
        {
          if (policyForRequiredNote.NoteTypeID != -1)
          {
            try
            {
              Cursor.Current = MgaCursors.WaitCursor;
              using (Form formEx = ObjectFactory.Instance.CreateFormEX(typeof (frmNote), (object) this.CreatePolicyEntity(quote)))
              {
                IMessageListener messageListener = TabDocumentPanel.Inspect<IMessageListener>((Control) formEx);
                if (messageListener != null)
                {
                  messageListener.OnMessageReceived(Note_System.UIInteractiveNoteManipulator.EventIdAutoInitializeNoteType, (object) policyForRequiredNote.NoteTypeID);
                  formEx.ShowInTaskbar = false;
                  formEx.StartPosition = FormStartPosition.CenterScreen;
                  int num = (int) formEx.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent);
                }
              }
            }
            finally
            {
              Cursor.Current = MgaCursors.Default;
            }
          }
        }
      }
      finally
      {
        List<NoteBindFailureReason>.Enumerator enumerator;
        enumerator.Dispose();
      }
      return this.CheckPolicyForRequiredNotes(quote, requirement);
    }

    private ISupportNoteSystem CreatePolicyEntity(Guid quote)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow("NoteSystem_FetchPolicyEntityInfo", new object[2]
      {
        (object) "@QuoteGuid",
        (object) quote
      });
      return (ISupportNoteSystem) new NoteSupportCache(quote, (string) dataRow["EntityName"], (string) dataRow["EntityFormName"], (string) dataRow["EntityType"], true, (Guid) dataRow["ControlGuid"]);
    }

    private List<NoteBindFailureReason> CheckPolicyForRequiredNotes(
      Guid quote,
      NoteBindRequirement requirement)
    {
      List<NoteBindFailureReason> reasons = Note_System.Instance.NonInteractive.QueryRequiredNotesOnPolicy(quote);
      this.FilterReasons(requirement, reasons);
      return reasons;
    }

    private void FilterReasons(NoteBindRequirement requirement, List<NoteBindFailureReason> reasons)
    {
      for (int index = reasons.Count - 1; index >= 0; index += -1)
      {
        NoteBindFailureReason reason = reasons[index];
        bool flag = false;
        switch (requirement)
        {
          case NoteBindRequirement.Quote:
            if (!reason.RequiredToQuote)
            {
              flag = true;
              break;
            }
            break;
          case NoteBindRequirement.Bind:
            if (!reason.RequiredToBind)
            {
              flag = true;
              break;
            }
            break;
        }
        if (flag)
          reasons.Remove(reason);
      }
    }

    public void ViewNoteFromEntryGUID(Guid entryGUID, ISupportNoteSystem noteSupport)
    {
      this.ViewNoteFromEntryGUID(entryGUID, true, noteSupport);
    }

    public void ViewNoteFromEntryGUID(
      Guid entryGUID,
      bool markRead,
      ISupportNoteSystem noteSupport)
    {
      this.ViewNote(Note_System.NonInteractiveNoteManipulator.NoteGUIDFromEntryGUID(entryGUID), entryGUID, markRead, noteSupport);
    }

    public bool CompleteDiary(Guid currentUserGuid, Guid diaryEntry, bool completed)
    {
      bool flag = false;
      List<Guid> diaryRecipients = Note_System.Instance.NonInteractive.GetDiaryRecipients(diaryEntry);
      if (diaryRecipients.Count == 1 && diaryRecipients[0].Equals(currentUserGuid))
      {
        Note_System.Instance.NonInteractive.CompleteDiaryEntry(diaryEntry, currentUserGuid, completed);
        flag = true;
      }
      else if (SecurityManager.Instance.AssertPermission("{777545E2-340A-4df5-A550-7BB58891C3F9}", 60))
      {
        if (diaryRecipients.Count == 1)
        {
          DataRow dataRow = Database.Instance.QuerySP.PerformRowQuery("NoteSystem_GetDiaryRecipientsStatusOnEntry", (object) "@EntryGuid", (object) diaryEntry);
          if (dataRow != null)
          {
            Note_System.Instance.NonInteractive.CompleteDiaryEntry(diaryEntry, (Guid) dataRow["userguid"], completed);
            if (MessageBox.Show("Send a notification to the affected user?", "Diary Completion status notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
              Note_System.Instance.NonInteractive.SendDiaryChangeNotification(diaryEntry, (Guid) dataRow["userguid"], completed);
            flag = true;
          }
        }
        else
        {
          using (CompleteDiaryMultiForm completeDiaryMultiForm = new CompleteDiaryMultiForm(diaryEntry, completed))
          {
            if (completeDiaryMultiForm.ShowDialog() == DialogResult.OK)
            {
              XmlDocument diaryRecipientChangeSetXml = Note_System.NonInteractiveNoteManipulator.BuildDiaryRecipientChangeSetXml(completeDiaryMultiForm.DiaryCompletedStatus);
              Note_System.Instance.NonInteractive.CompleteDiarySet(diaryEntry, diaryRecipientChangeSetXml);
              if (completeDiaryMultiForm.SendCompletionNotice)
                Note_System.Instance.NonInteractive.SendDiaryChangeNotification(diaryEntry, diaryRecipientChangeSetXml);
              flag = true;
            }
          }
        }
      }
      else if (diaryRecipients.Contains(currentUserGuid))
      {
        Note_System.Instance.NonInteractive.CompleteDiaryEntry(diaryEntry, currentUserGuid, completed);
        flag = true;
      }
      else
      {
        int num = (int) MessageBox.Show("You are not a recipient on this diary, and you do not have permission to complete it.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUrgent);
      this.NoteSystem.FireCollectionModified(NoteCollections.NotesBound);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesUpcoming);
      this.NoteSystem.FireCollectionModified(NoteCollections.DiaryEntriesAllOpen);
      this.NoteSystem.FireCollectionModified(NoteCollections.NoteEntriesOpen);
      return flag;
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "noteGUID")]
    [Obsolete("This method doesnt do anything")]
    public void BeginDisplayAssociatedEntity(Guid noteGUID)
    {
      int num = (int) Interaction.MsgBox((object) "This functionality has been temporarily disabled.");
    }
  }
}
