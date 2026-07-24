// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteAutomation
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[StandardModule]
public sealed class NoteAutomation
{
  private static DataSet PerformQuery(string query, params object[] args)
  {
    DataSet ds = new DataSet();
    using (SqlConnection connection = new SqlConnection(Database.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand(query, connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        Database.InitializeParameters(sqlCommand, args);
        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
          Database.SafeDataAdapterFill(dataAdapter, ds);
      }
    }
    return ds;
  }

  public static void FireEvent(
    Guid eventGuid,
    Guid controlGuid,
    Guid companyLineGuid,
    int quoteId,
    int? templateId)
  {
    List<PendingNote> noteList = new List<PendingNote>();
    NoteAutomation.HandleEventAtCompanyLineLevel(noteList, eventGuid, controlGuid, companyLineGuid, quoteId);
    NoteAutomation.HandleEventAtGlobalLevel(noteList, eventGuid, controlGuid, companyLineGuid, quoteId, templateId);
    if (noteList.Count == 0)
      return;
    Dictionary<Guid, PendingNote> boundNoteList = new Dictionary<Guid, PendingNote>();
    Form form = (Form) null;
    try
    {
      PendingNoteUIOverride objectAs = ObjectFactory.Instance.CreateObjectAs<PendingNoteUIOverride>();
      if (objectAs.HasUI)
      {
        form = objectAs.CreateUI(noteList, quoteId);
        int num = (int) form.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent);
      }
      try
      {
        foreach (PendingNote pendingNote in noteList)
        {
          Guid boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(pendingNote.NoteType, pendingNote.Subject, pendingNote.OriginatorGuid, pendingNote.Body, false, (Guid[]) null, pendingNote.GetDiaryRecipients(), (ISupportNoteSystem) pendingNote.NoteSupport, pendingNote.DueDate, pendingNote.FinalDueDate, pendingNote.Popup);
          boundNoteList.Add(boundNote, pendingNote);
        }
      }
      finally
      {
        List<PendingNote>.Enumerator enumerator;
        enumerator.Dispose();
      }
      objectAs.ProcessBoundNotesOnClient(quoteId, boundNoteList);
    }
    finally
    {
      form?.Dispose();
    }
  }

  public static void FireEvent(Guid eventGuid, Guid contextGuid, int? templateId)
  {
    List<PendingNote> noteList = new List<PendingNote>();
    NoteAutomation.HandleEventClaims(noteList, eventGuid, contextGuid, templateId);
    if (noteList.Count == 0)
      return;
    Dictionary<Guid, PendingNote> dictionary = new Dictionary<Guid, PendingNote>();
    Form form = (Form) null;
    try
    {
      PendingNoteUIOverride objectAs = ObjectFactory.Instance.CreateObjectAs<PendingNoteUIOverride>();
      if (objectAs.HasUI)
      {
        form = objectAs.CreateUI(noteList);
        int num = (int) form.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent);
      }
      try
      {
        foreach (PendingNote pendingNote in noteList)
        {
          Guid boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(pendingNote.NoteType, pendingNote.Subject, pendingNote.OriginatorGuid, pendingNote.Body, false, (Guid[]) null, pendingNote.GetDiaryRecipients(), (ISupportNoteSystem) pendingNote.NoteSupport, pendingNote.DueDate, pendingNote.FinalDueDate, pendingNote.Popup);
          dictionary.Add(boundNote, pendingNote);
        }
      }
      finally
      {
        List<PendingNote>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      form?.Dispose();
    }
  }

  public static void HandleEventAtGlobalLevel(
    List<PendingNote> noteList,
    Guid eventGuid,
    Guid controlGuid,
    Guid companyLineGuid,
    int quoteId,
    int? templateId)
  {
    DataSet dataSet;
    if (templateId.HasValue)
      dataSet = DefaultDatabase.ExecuteDataSet("NoteSystem_FetchApplicableAutomationNotes", new object[10]
      {
        (object) "@eventGuid",
        (object) eventGuid,
        (object) "@controlGuid",
        (object) controlGuid,
        (object) "@companyLineGuid",
        (object) companyLineGuid,
        (object) "@templateId",
        (object) templateId.Value,
        (object) "@quoteId",
        (object) quoteId
      });
    else
      dataSet = DefaultDatabase.ExecuteDataSet("NoteSystem_FetchApplicableAutomationNotes", new object[8]
      {
        (object) "@eventGuid",
        (object) eventGuid,
        (object) "@controlGuid",
        (object) controlGuid,
        (object) "@companyLineGuid",
        (object) companyLineGuid,
        (object) "@quoteId",
        (object) quoteId
      });
    NoteAutomationRecipientManager recipientManager = (NoteAutomationRecipientManager) ObjectFactory.Instance.CreateObject(typeof (NoteAutomationRecipientManager));
    if ((object) ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail") == null)
      throw new InvalidOperationException("NoteAutomation was unable to resolve the frmPolicyDetailType");
    try
    {
      foreach (DataRow row in dataSet.Tables[0].Rows)
      {
        string subject = Conversions.ToString(row["NoteSubject"]);
        string body = Conversions.ToString(row["NoteBody"]);
        DateTime date = Conversions.ToDate(row["DueDate"]);
        bool boolean1 = Conversions.ToBoolean(row["Popup"]);
        int integer = Conversions.ToInteger(row["Type"]);
        bool boolean2 = Conversions.ToBoolean(row["IncludeEmail"]);
        bool boolean3 = Conversions.ToBoolean(row["Mandatory"]);
        bool boolean4 = Conversions.ToBoolean(row["RequiredToBind"]);
        List<Guid> guidList1 = new List<Guid>();
        List<Guid> guidList2 = recipientManager.ResolveAutomationRecipients(Conversions.ToInteger(row["NoteAutomationRecipientID"]), controlGuid, companyLineGuid, quoteId);
        List<Guid> recipientGuidList = GlobalNoteAutomationRecipient.GetGlobalNoteAutomationRecipientGuidList(Conversions.ToInteger(row["NoteAutomationID"]));
        try
        {
          foreach (Guid guid in recipientGuidList)
          {
            if (!guidList2.Contains(guid))
              guidList2.Add(guid);
          }
        }
        finally
        {
          List<Guid>.Enumerator enumerator;
          enumerator.Dispose();
        }
        NoteSupportCache noteSupport = new NoteSupportCache(controlGuid, $"Policy: {dataSet.Tables[1].Rows[0][1].ToString()} / {dataSet.Tables[1].Rows[0]["InsuredPolicyName"].ToString()}", "Policy: " + dataSet.Tables[1].Rows[0][1].ToString(), "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, controlGuid);
        noteList.Add(new PendingNote(integer, subject, CurrentUser.Instance.UserGUID, body, noteSupport, date, guidList2.ToArray(), boolean1, boolean2, boolean3, boolean4));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void HandleEventAtCompanyLineLevel(
    List<PendingNote> noteList,
    Guid eventGuid,
    Guid controlGuid,
    Guid companyLineGuid,
    int quoteId)
  {
    DataTable dataTable1 = DefaultDatabase.ExecuteDataTable("NoteSystem_FetchApplicableAutomationNotesAtCompanyLineLevel", new object[4]
    {
      (object) "@CompanyLineGuid",
      (object) companyLineGuid,
      (object) "@EventGuid",
      (object) eventGuid
    });
    try
    {
      foreach (DataRow row in dataTable1.Rows)
      {
        string subject = Conversions.ToString(row["NoteSubject"]);
        string body = Conversions.ToString(row["NoteBody"]);
        DateTime dateTime;
        switch (Conversions.ToInteger(row["DiaryStartDateID"]))
        {
          case 0:
            dateTime = DateAndTime.Now;
            break;
          case 1:
            dateTime = DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "select EffectiveDate from tblquotes where quoteid = @quoteID", new object[2]
            {
              (object) "@quoteID",
              (object) quoteId
            });
            break;
          case 2:
            dateTime = DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "select ExpirationDate from tblquotes where quoteid = @quoteID", new object[2]
            {
              (object) "@quoteID",
              (object) quoteId
            });
            break;
          default:
            throw new InvalidOperationException($"The value {Conversions.ToInteger(row["DiaryStartDateID"])} is not a valid startDateID");
        }
        DateTime dueDate = dateTime.AddDays((double) Conversions.ToInteger(row["DueInDays"]));
        bool boolean1 = Conversions.ToBoolean(row["Popup"]);
        int integer = Conversions.ToInteger(row["Type"]);
        bool boolean2 = Conversions.ToBoolean(row["IncludeEmail"]);
        bool boolean3 = Conversions.ToBoolean(row["Mandatory"]);
        bool boolean4 = Conversions.ToBoolean(row["RequiredToBind"]);
        List<Guid> guidList1 = new List<Guid>();
        List<Guid> guidList2 = ((NoteAutomationRecipientManager) ObjectFactory.Instance.CreateObject(typeof (NoteAutomationRecipientManager))).ResolveAutomationRecipients(Conversions.ToInteger(row["NoteAutomationRecipientID"]), controlGuid, companyLineGuid, quoteId);
        if ((object) ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail") == null)
          throw new InvalidOperationException("NoteAutomation was unable to resolve the frmPolicyDetailType");
        DataRow dataRow = Database.Instance.QueryText.PerformRowQuery("SELECT TOP 1 InsuredPolicyName, ControlNo FROM tblQuotes WHERE ControlGuid = @ControlGuid ORDER BY QuoteID DESC", (object) "@ControlGuid", (object) controlGuid);
        NoteSupportCache noteSupport = new NoteSupportCache(controlGuid, $"Policy: {dataRow[1].ToString()} / {dataRow["InsuredPolicyName"].ToString()}", "Policy: " + dataRow[1].ToString(), "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, controlGuid);
        noteList.Add(new PendingNote(integer, subject, CurrentUser.Instance.UserGUID, body, noteSupport, dueDate, guidList2.ToArray(), boolean1, boolean2, boolean3, boolean4));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (eventGuid == BroadcastMessages.QuotePrinted)
    {
      DataTable dataTable2 = DefaultDatabase.ExecuteDataTable("NoteSystem_FetchApplicableAutomationReasonsNewQuote", new object[4]
      {
        (object) "@quoteId",
        (object) quoteId,
        (object) "@companyLineGuid",
        (object) companyLineGuid
      });
      if (dataTable2 != null)
      {
        DataRow dataRow = Database.Instance.QueryText.PerformRowQuery("SELECT TOP 1 InsuredPolicyName, ControlNo FROM tblQuotes WHERE ControlGuid = @ControlGuid ORDER BY QuoteID DESC", (object) "@ControlGuid", (object) controlGuid);
        NoteSupportCache noteSupport = new NoteSupportCache(controlGuid, $"Policy: {dataRow[1].ToString()} / {dataRow["InsuredPolicyName"].ToString()}", "Policy: " + dataRow[1].ToString(), "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, controlGuid);
        NoteAutomationRecipientManager recipientManager = (NoteAutomationRecipientManager) ObjectFactory.Instance.CreateObject(typeof (NoteAutomationRecipientManager));
        List<Guid> guidList3 = new List<Guid>();
        Guid controlGuid1 = controlGuid;
        Guid companyLineGuid1 = companyLineGuid;
        int quoteId1 = quoteId;
        List<Guid> guidList4 = recipientManager.ResolveAutomationRecipients(1, controlGuid1, companyLineGuid1, quoteId1);
        try
        {
          foreach (DataRow row in dataTable2.Rows)
          {
            string body = "Must complete item.";
            string subject = $"Policy {Conversions.ToString(row["Note"])}";
            int integer = Conversions.ToInteger(row["NoteTypeID"]);
            noteList.Add(new PendingNote(integer, subject, CurrentUser.Instance.UserGUID, body, noteSupport, DateAndTime.Now.AddDays(10.0), guidList4.ToArray(), false, false, false, false));
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
    if (!eventGuid.Equals(BroadcastMessages.PolicyBound) && !eventGuid.Equals(BroadcastMessages.RenewalBound))
      return;
    DataTable dataTable3 = DefaultDatabase.ExecuteDataTable("NoteSystem_FetchApplicableAutomationReasons", new object[4]
    {
      (object) "@quoteId",
      (object) quoteId,
      (object) "@companyLineGuid",
      (object) companyLineGuid
    });
    if (dataTable3 == null)
      return;
    DataRow dataRow1 = Database.Instance.QueryText.PerformRowQuery("SELECT TOP 1 InsuredPolicyName, ControlNo FROM tblQuotes WHERE ControlGuid = @ControlGuid ORDER BY QuoteID DESC", (object) "@ControlGuid", (object) controlGuid);
    NoteSupportCache noteSupport1 = new NoteSupportCache(controlGuid, $"Policy: {dataRow1[1].ToString()} / {dataRow1["InsuredPolicyName"].ToString()}", "Policy: " + dataRow1[1].ToString(), "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, controlGuid);
    NoteAutomationRecipientManager recipientManager1 = (NoteAutomationRecipientManager) ObjectFactory.Instance.CreateObject(typeof (NoteAutomationRecipientManager));
    List<Guid> guidList5 = new List<Guid>();
    List<Guid> guidList6 = recipientManager1.ResolveAutomationRecipients(recipientManager1.GetRecipientType(noteList, eventGuid, controlGuid, companyLineGuid, quoteId), controlGuid, companyLineGuid, quoteId);
    try
    {
      foreach (DataRow row in dataTable3.Rows)
      {
        string body = "Must complete item.";
        string subject = $"Policy {Conversions.ToString(row["Note"])}";
        int integer = Conversions.ToInteger(row["NoteTypeID"]);
        noteList.Add(new PendingNote(integer, subject, CurrentUser.Instance.UserGUID, body, noteSupport1, DateAndTime.Now.AddDays(10.0), guidList6.ToArray(), false, false, false, false));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void HandleEventClaims(
    List<PendingNote> noteList,
    Guid eventGuid,
    Guid contextGuid,
    int? templateId)
  {
    DataRow row1 = DefaultDatabase.ExecuteDataRow("spGetQuoteInfoFromClaimGuid", new object[2]
    {
      (object) "@claimGuid",
      (object) contextGuid
    });
    DataTable dataTable;
    if (row1 != null)
    {
      DataSet dataSet;
      if (templateId.HasValue)
        dataSet = DefaultDatabase.ExecuteDataSet("NoteSystem_FetchApplicableAutomationNotes", new object[10]
        {
          (object) "@eventGuid",
          (object) eventGuid,
          (object) "@controlGuid",
          (object) row1.Field<Guid>("ControlGuid"),
          (object) "@companyLineGuid",
          (object) row1.Field<Guid>("CompanyLineGUID"),
          (object) "@templateId",
          (object) templateId.Value,
          (object) "@quoteId",
          (object) row1.Field<int>("QuoteID")
        });
      else
        dataSet = DefaultDatabase.ExecuteDataSet("NoteSystem_FetchApplicableAutomationNotes", new object[8]
        {
          (object) "@eventGuid",
          (object) eventGuid,
          (object) "@controlGuid",
          (object) row1.Field<Guid>("ControlGuid"),
          (object) "@companyLineGuid",
          (object) row1.Field<Guid>("CompanyLineGUID"),
          (object) "@quoteId",
          (object) row1.Field<int>("QuoteID")
        });
      dataTable = dataSet.Tables[0];
    }
    else if (templateId.HasValue)
      dataTable = DefaultDatabase.ExecuteDataTable("NoteSystem_FetchApplicableAutomationNotesGeneric", new object[4]
      {
        (object) "@EventGuid",
        (object) eventGuid,
        (object) "@templateId",
        (object) templateId.Value
      });
    else
      dataTable = DefaultDatabase.ExecuteDataTable("NoteSystem_FetchApplicableAutomationNotesGeneric", new object[4]
      {
        (object) "@EventGuid",
        (object) eventGuid,
        (object) "@templateId",
        null
      });
    try
    {
      foreach (DataRow row2 in dataTable.Rows)
      {
        string subject = Conversions.ToString(row2["NoteSubject"]);
        string body = Conversions.ToString(row2["NoteBody"]);
        DateTime now = DateAndTime.Now;
        DateTime dueDate = !dataTable.Columns.Contains("DueInDays") ? Conversions.ToDate(row2["DueDate"]) : now.AddDays((double) Conversions.ToInteger(row2["DueInDays"]));
        bool boolean1 = Conversions.ToBoolean(row2["Popup"]);
        int integer1 = Conversions.ToInteger(row2["Type"]);
        bool boolean2 = Conversions.ToBoolean(row2["IncludeEmail"]);
        bool boolean3 = Conversions.ToBoolean(row2["Mandatory"]);
        int integer2 = Conversions.ToInteger(row2["NoteAutomationRecipientID"]);
        bool boolean4 = Conversions.ToBoolean(row2["RequiredToBind"]);
        bool setting = SystemSettings.GetSetting<bool>("ClaimsNoteUsesClaimant", false);
        List<Guid> guidList = new List<Guid>();
        NoteAutomationRecipientManager recipientManager = (NoteAutomationRecipientManager) ObjectFactory.Instance.CreateObject(typeof (NoteAutomationRecipientManager));
        if (row1 != null)
        {
          switch (integer2)
          {
            case 6:
              if (setting)
              {
                guidList.AddRange((IEnumerable<Guid>) recipientManager.ResolveAutomationRecipients(integer2, contextGuid, row1.Field<Guid>("CompanyLineGUID"), row1.Field<int>("QuoteID")));
                if (guidList.Count == 0)
                  return;
                goto label_18;
              }
              break;
            case 10:
              guidList.AddRange((IEnumerable<Guid>) recipientManager.ResolveAutomationRecipients(integer2, contextGuid, row1.Field<Guid>("CompanyLineGUID"), row1.Field<int>("QuoteID")));
              goto label_18;
          }
          guidList.AddRange((IEnumerable<Guid>) recipientManager.ResolveAutomationRecipients(integer2, row1.Field<Guid>("ControlGuid"), row1.Field<Guid>("CompanyLineGUID"), row1.Field<int>("QuoteID")));
        }
        else
          guidList.Add(CurrentUser.Instance.UserGUID);
label_18:
        NoteSupportCache noteSupport = new NoteSupportCache(contextGuid, "Claims", "MGASystems.IMS.Claims.FormClaims", "MGASystems.IMS.Claims.FormClaims", false, Guid.Empty);
        noteList.Add(new PendingNote(integer1, subject, CurrentUser.Instance.UserGUID, body, noteSupport, dueDate, guidList.ToArray(), boolean1, boolean2, boolean3, boolean4));
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
