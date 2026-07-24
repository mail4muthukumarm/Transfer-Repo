// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.OutlookMessageHandler
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.AsposeFacade.Email.Outlook;
using MGASystems.Common;
using MGASystems.IMS.Logging;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public sealed class OutlookMessageHandler
{
  private static OutlookMessageHandler.FileFoundHandler _fileFoundHandler;

  private OutlookMessageHandler()
  {
  }

  public static MailMetaData GetMailMetaData(string outlookMessageFilePath)
  {
    try
    {
      Log.Write($"DocumentManager.{"GetMailMetaData.outlookMessageFilePath"} {outlookMessageFilePath}", "DocumentSystem.DocumentManager");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    MailMetaData mailMetaData1;
    if (File.Exists(outlookMessageFilePath))
    {
      MailMetaData mailMetaData2 = new MailMetaData();
      MapiMessage msg = MapiMessage.FromFile(outlookMessageFilePath);
      MapiProperty property1 = msg.Properties[MapiPropertyTag.PR_CLIENT_SUBMIT_TIME];
      if (property1 != null)
      {
        mailMetaData2.Sent = property1.GetDateTime();
        mailMetaData2.SentString = mailMetaData2.Sent.ToShortDateString();
      }
      else
      {
        mailMetaData2.Sent = DateTime.MinValue;
        mailMetaData2.SentString = "";
      }
      MapiProperty property2 = msg.Properties[MapiPropertyTag.PR_MESSAGE_DELIVERY_TIME];
      if (property2 != null)
      {
        mailMetaData2.Received = property2.GetDateTime();
        mailMetaData2.ReceivedString = mailMetaData2.Sent.ToShortDateString();
      }
      else
      {
        mailMetaData2.Received = DateTime.MinValue;
        mailMetaData2.ReceivedString = "";
      }
      mailMetaData2.Body = OutlookMessageHandler.GetBody(msg, 800);
      mailMetaData2.Subject = OutlookMessageHandler.GetSubject(msg, 200);
      mailMetaData1 = mailMetaData2;
    }
    else
      mailMetaData1 = new MailMetaData();
    return mailMetaData1;
  }

  private static string GetBody(MapiMessage msg, int maxLength)
  {
    string str = string.Empty;
    if (msg.Body != null)
      str = msg.Body;
    else if (msg.BodyRtf != null)
    {
      using (RichTextBox richTextBox = new RichTextBox())
      {
        richTextBox.Rtf = msg.BodyRtf;
        str = richTextBox.Text;
      }
    }
    else
    {
      MapiProperty mapiProperty = msg.Properties[MapiPropertyTag.PR_BODY] ?? msg.Properties[MapiPropertyTag.PR_BODY_W] ?? msg.Properties[MapiPropertyTag.PR_BODY_A] ?? msg.Properties[MapiPropertyTag.PR_RTF_SYNC_BODY_TAG] ?? msg.Properties[MapiPropertyTag.PR_RTF_SYNC_BODY_TAG_A] ?? msg.Properties[MapiPropertyTag.PR_RTF_SYNC_BODY_TAG_W];
      if (mapiProperty != null)
        str = mapiProperty.GetString();
    }
    if (str == null)
      str = string.Empty;
    string body = str.Trim();
    if (body.Length > maxLength)
      body = body.Substring(0, maxLength);
    return body;
  }

  private static string GetSubject(MapiMessage msg, int maxLength)
  {
    string subject = string.Empty;
    MapiProperty mapiProperty = msg.Properties[MapiPropertyTag.PR_SUBJECT] ?? msg.Properties[MapiPropertyTag.PR_SUBJECT_W] ?? msg.Properties[MapiPropertyTag.PR_SUBJECT_A];
    if (mapiProperty != null)
    {
      subject = (mapiProperty.GetString() ?? string.Empty).Trim();
      if (subject.Length > maxLength)
        subject = subject.Substring(0, maxLength);
    }
    return subject;
  }

  public static void ExtractAttachments(
    string outlookMessageFilePath,
    OutlookMessageHandler.FileFoundHandler fileFoundHandler)
  {
    OutlookMessageHandler._fileFoundHandler = fileFoundHandler != null ? fileFoundHandler : throw new ArgumentNullException(nameof (fileFoundHandler));
    MapiMessage mapiMessage = MapiMessage.FromFile(outlookMessageFilePath);
    try
    {
      foreach (MapiAttachment attachment in (IEnumerable<MapiAttachment>) mapiMessage.Attachments)
      {
        string file = $"{MGATempFolder.CreateTempSubdirectory()}{attachment.FileName}";
        attachment.Save(file);
        OutlookMessageHandler._fileFoundHandler(file);
      }
    }
    finally
    {
      IEnumerator<MapiAttachment> enumerator;
      enumerator?.Dispose();
    }
  }

  public delegate void FileFoundHandler(string file);
}
