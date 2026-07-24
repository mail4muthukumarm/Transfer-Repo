// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.Email.UI
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.AsposeFacade.Windows.Forms;
using MGASystems.Common;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.Email;

[SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
[LogCategory("DocumentSystem.Email", "DocumentSystem.Email")]
public sealed class UI
{
  public const string LogKey = "DocumentSystem.Email";

  private UI()
  {
  }

  public static void Send(string[] attachmentPaths) => UI.Send(attachmentPaths, (string[]) null);

  public static void Send(ISupportDocumentSystem docSupport, string[] attachmentPaths)
  {
    UI.Send(docSupport, attachmentPaths, (string[]) null);
  }

  public static void Send(string[] attachmentPaths, string[] recipients)
  {
    UI.Send(attachmentPaths, recipients, string.Empty);
  }

  public static void Send(
    ISupportDocumentSystem docSupport,
    string[] attachmentPaths,
    string[] recipients)
  {
    UI.Send(docSupport, attachmentPaths, recipients, string.Empty);
  }

  public static void Send(
    string[] attachmentPaths,
    string[] recipients,
    string subject,
    string[] ccList)
  {
    UI.Send(attachmentPaths, recipients, subject, (string[]) null, (string) null);
  }

  public static void Send(
    ISupportDocumentSystem docSupport,
    string[] attachmentPaths,
    string[] recipients,
    string subject,
    string[] ccList)
  {
    UI.Send(docSupport, attachmentPaths, recipients, subject, (string[]) null, (string) null);
  }

  public static void Send(string[] attachmentPaths, string[] recipients, string subject)
  {
    UI.Send(attachmentPaths, recipients, subject, (string[]) null);
  }

  public static void Send(
    ISupportDocumentSystem docSupport,
    string[] attachmentPaths,
    string[] recipients,
    string subject)
  {
    UI.Send(docSupport, attachmentPaths, recipients, subject, (string[]) null);
  }

  public static void Send(
    string[] attachmentPaths,
    string[] recipients,
    string subject,
    string[] ccList,
    string emailBody)
  {
    UI.Send((ISupportDocumentSystem) null, attachmentPaths, recipients, subject, ccList, emailBody);
  }

  public static void Send(
    ISupportDocumentSystem docSupport,
    string[] attachmentPaths,
    string[] recipients,
    string subject,
    string[] ccList,
    string emailBody)
  {
    UI.Send(docSupport, attachmentPaths, recipients, subject, ccList, (string[]) null, emailBody);
  }

  public static void Send(
    ISupportDocumentSystem docSupport,
    string[] attachmentPaths,
    string[] recipients,
    string subject,
    string[] ccList,
    string[] bcList,
    string emailBody)
  {
    bool flag = CurrentUser.UsingOutlook;
    List<string> attachmentPaths1 = new List<string>();
    if (attachmentPaths != null)
      attachmentPaths1.AddRange((IEnumerable<string>) attachmentPaths);
    else
      attachmentPaths1.Add(string.Empty);
    List<string> recipients1 = new List<string>();
    if (recipients != null)
      recipients1.AddRange((IEnumerable<string>) recipients);
    else
      recipients1.Add(string.Empty);
    List<string> ccList1 = (List<string>) null;
    if (ccList != null)
      ccList1 = new List<string>((IEnumerable<string>) ccList);
    List<string> bcList1 = (List<string>) null;
    if (bcList != null)
      bcList1 = new List<string>((IEnumerable<string>) bcList);
    if (flag)
    {
      try
      {
        Log.Write("Outlook Detected: Attempting to send mail via Outlook", "DocumentSystem.Email");
        Hashtable userProperties = (Hashtable) null;
        if (docSupport != null)
        {
          userProperties = new Hashtable();
          userProperties.Add((object) "MGASystems.IMS.Email.DocSupport", (object) new DocSupportCache(docSupport).ToString());
        }
        flag = emailBody != null ? SMTP_Email.SendUsingOutlook(userProperties, attachmentPaths1, recipients1, subject, emailBody, ccList1, bcList1, SMTP_Email.ShowOrSend.Show, true, true) : SMTP_Email.SendUsingOutlook(userProperties, attachmentPaths1, recipients1, subject, string.Empty, ccList1, bcList1, SMTP_Email.ShowOrSend.Show, true, true);
        Log.Write("Send mail via Outlook Success", "DocumentSystem.Email");
      }
      catch (COMException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        COMException comException = ex;
        Log.Write("An error occurred while trying to send email thru Outlook " + comException.Message, "DocumentSystem.Email");
        int num = (int) MessageBox.Show("The IMS was unable to create a Microsoft Outlook email at this time.\n\nIf this problem persists, please contact technical support.\n\n" + comException.Message, "Outlook Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
        return;
      }
    }
    if (flag)
      return;
    Log.Write("Outlook Not Detected: via Default Client", "DocumentSystem.Email");
    RecipientCollection recipientCollection = new RecipientCollection();
    if (recipients != null)
    {
      string[] strArray = recipients;
      int index = 0;
      while (index < strArray.Length)
      {
        string str = strArray[index];
        recipientCollection.Add(str);
        checked { ++index; }
      }
    }
    if (ccList != null)
    {
      string[] strArray = ccList;
      int index = 0;
      while (index < strArray.Length)
      {
        string str = strArray[index];
        recipientCollection.Add(str, (RecipientType) 2);
        checked { ++index; }
      }
    }
    new MailClientAgent().Launch(string.Empty, string.Empty, recipientCollection, attachmentPaths);
    Log.Write("Send mail via Default Client Success", "DocumentSystem.Email");
  }

  public string GetStringFromMemoryStream(MemoryStream m)
  {
    string fromMemoryStream;
    if (Information.IsNothing((object) m))
    {
      fromMemoryStream = (string) null;
    }
    else
    {
      m.Flush();
      m.Position = 0L;
      fromMemoryStream = new StreamReader((Stream) m).ReadToEnd();
    }
    return fromMemoryStream;
  }
}
