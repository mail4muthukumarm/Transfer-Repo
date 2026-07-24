// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.MapiEmail
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.IMS.Forms;

[StandardModule]
public sealed class MapiEmail
{
  private const int MAPI_DIALOG = 8;
  private const int MAPI_TO = 1;
  private const int MAPI_CC = 2;

  [DllImport("MAPI32.DLL")]
  private static extern MapiEmail.MapiResult MAPISendMail(
    IntPtr Session,
    IntPtr hwnd,
    ref MapiEmail.MapiMessage msg,
    int Flag,
    int Reserved);

  private static IntPtr AllocateAttachments(
    string[] filePaths,
    string[] fileNames,
    ref int totalFilesCount)
  {
    totalFilesCount = 0;
    if (filePaths == null)
      totalFilesCount += 0;
    else
      totalFilesCount += filePaths.Length;
    IntPtr num1;
    if (totalFilesCount > 0)
    {
      int num2 = Marshal.SizeOf(typeof (MapiEmail.MapiFile));
      IntPtr num3 = Marshal.AllocHGlobal(totalFilesCount * num2);
      int int32 = num3.ToInt32();
      if (filePaths != null)
      {
        int num4 = filePaths.Length - 1;
        for (int index = 0; index <= num4; ++index)
        {
          Marshal.StructureToPtr<MapiEmail.MapiFile>(new MapiEmail.MapiFile()
          {
            PathName = filePaths[index],
            FileName = fileNames[index]
          }, new IntPtr(int32), false);
          int32 += num2;
        }
      }
      num1 = num3;
    }
    else
      num1 = IntPtr.Zero;
    return num1;
  }

  private static IntPtr AllocateRecipients(
    string[] toAddresses,
    string[] ccAddresses,
    ref int totalAddressCount)
  {
    totalAddressCount = 0;
    if (toAddresses == null)
      totalAddressCount += 0;
    else
      totalAddressCount += toAddresses.Length;
    if (ccAddresses == null)
      totalAddressCount += 0;
    else
      totalAddressCount += ccAddresses.Length;
    IntPtr num1;
    if (totalAddressCount > 0)
    {
      int num2 = Marshal.SizeOf(typeof (MapiEmail.MapiRecipient));
      IntPtr num3 = Marshal.AllocHGlobal(totalAddressCount * num2);
      int int32 = num3.ToInt32();
      if (toAddresses != null)
      {
        int num4 = toAddresses.Length - 1;
        for (int index = 0; index <= num4; ++index)
        {
          Marshal.StructureToPtr<MapiEmail.MapiRecipient>(new MapiEmail.MapiRecipient()
          {
            RecipientClass = 1,
            Name = toAddresses[index]
          }, new IntPtr(int32), false);
          int32 += num2;
        }
      }
      if (ccAddresses != null)
      {
        int num5 = ccAddresses.Length - 1;
        for (int index = 0; index <= num5; ++index)
        {
          Marshal.StructureToPtr<MapiEmail.MapiRecipient>(new MapiEmail.MapiRecipient()
          {
            RecipientClass = 2,
            Name = ccAddresses[index]
          }, new IntPtr(int32), false);
          int32 += num2;
        }
      }
      num1 = num3;
    }
    else
      num1 = IntPtr.Zero;
    return num1;
  }

  public static MapiEmail.MapiResult SendMail(string subject, string body)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, (string[]) null, (string[]) null, (string[]) null, (string[]) null, MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMail(
    string subject,
    string body,
    params string[] toRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, (string[]) null, (string[]) null, (string[]) null, MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMail(
    string subject,
    string body,
    string[] toRecipients,
    params string[] ccRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, ccRecipients, (string[]) null, (string[]) null, MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    MapiEmail.AttachmentOptions attachmentOptions,
    string[] filePaths,
    string[] fileDisplayNames)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, (string[]) null, (string[]) null, filePaths, fileDisplayNames, attachmentOptions);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    MapiEmail.AttachmentOptions attachmentOptions,
    string[] filePaths,
    string[] fileDisplayNames,
    params string[] toRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, (string[]) null, filePaths, fileDisplayNames, attachmentOptions);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    MapiEmail.AttachmentOptions attachmentOptions,
    string[] filePaths,
    string[] fileDisplayNames,
    string[] toRecipients,
    params string[] ccRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, ccRecipients, filePaths, fileDisplayNames, attachmentOptions);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    MapiEmail.AttachmentOptions attachmentOptions,
    params string[] filePaths)
  {
    ArrayList arrayList = new ArrayList();
    string[] strArray = filePaths;
    int index = 0;
    while (index < strArray.Length)
    {
      string str = strArray[index];
      FileInfo fileInfo = File.Exists(str) ? new FileInfo(str) : throw new FileNotFoundException($"Coult not locate {str}");
      arrayList.Add((object) fileInfo.Name);
      checked { ++index; }
    }
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, (string[]) null, (string[]) null, filePaths, (string[]) arrayList.ToArray(typeof (string)), attachmentOptions);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    string[] filePaths,
    string[] fileDisplayNames)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, (string[]) null, (string[]) null, filePaths, fileDisplayNames, MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    string[] filePaths,
    string[] fileDisplayNames,
    params string[] toRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, (string[]) null, filePaths, fileDisplayNames, MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    string[] filePaths,
    string[] fileDisplayNames,
    string[] toRecipients,
    params string[] ccRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, ccRecipients, filePaths, fileDisplayNames, MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMailWithAttachmentEx(
    string subject,
    string body,
    params string[] filePaths)
  {
    ArrayList arrayList = new ArrayList();
    string[] strArray = filePaths;
    int index = 0;
    while (index < strArray.Length)
    {
      string str = strArray[index];
      FileInfo fileInfo = File.Exists(str) ? new FileInfo(str) : throw new FileNotFoundException($"Coult not locate {str}");
      arrayList.Add((object) fileInfo.Name);
      checked { ++index; }
    }
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, (string[]) null, (string[]) null, filePaths, (string[]) arrayList.ToArray(typeof (string)), MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMailWithAttachment(
    string subject,
    string body,
    string[] filePaths,
    params string[] toRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, (string[]) null, filePaths, MapiEmail.GetDisplayNames(filePaths), MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMailWithAttachment(
    string subject,
    string body,
    string[] filePaths,
    string[] toRecipients,
    params string[] ccRecipients)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, toRecipients, ccRecipients, filePaths, MapiEmail.GetDisplayNames(filePaths), MapiEmail.AttachmentOptions.None);
  }

  public static MapiEmail.MapiResult SendMailWithAttachment(
    string subject,
    string body,
    params string[] filePaths)
  {
    return MapiEmail.InternalSendMapiMessageWithAttachment(subject, body, (string[]) null, (string[]) null, filePaths, MapiEmail.GetDisplayNames(filePaths), MapiEmail.AttachmentOptions.None);
  }

  private static string[] GetDisplayNames(string[] filePaths)
  {
    ArrayList arrayList = new ArrayList();
    string[] strArray = filePaths;
    int index = 0;
    while (index < strArray.Length)
    {
      string str = strArray[index];
      FileInfo fileInfo = File.Exists(str) ? new FileInfo(str) : throw new FileNotFoundException($"Coult not locate {str}");
      arrayList.Add((object) fileInfo.Name);
      checked { ++index; }
    }
    return (string[]) arrayList.ToArray(typeof (string));
  }

  private static MapiEmail.MapiResult InternalSendMapiMessageWithAttachment(
    string subject,
    string body,
    string[] toAddresses,
    string[] ccAddresses,
    string[] filePaths,
    string[] fileNames,
    MapiEmail.AttachmentOptions attachmentOptions)
  {
    MapiEmail.MapiResult mapiResult1;
    if (filePaths != null ^ fileNames != null || filePaths != null && fileNames != null && filePaths.Length != fileNames.Length)
    {
      mapiResult1 = MapiEmail.MapiResult.Failure;
    }
    else
    {
      MapiEmail.MapiMessage msg = new MapiEmail.MapiMessage();
      msg.Subject = subject == null || subject.Length <= 0 ? " " : subject;
      msg.NoteText = body == null || body.Length <= 0 ? " " : body;
      if (attachmentOptions != MapiEmail.AttachmentOptions.CollateAttachments)
        ;
      IntPtr zero1 = IntPtr.Zero;
      IntPtr zero2 = IntPtr.Zero;
      MapiEmail.MapiResult mapiResult2;
      try
      {
        int totalAddressCount;
        IntPtr num1 = MapiEmail.AllocateRecipients(toAddresses, ccAddresses, ref totalAddressCount);
        msg.RecipientCount = totalAddressCount;
        msg.Recipients = num1;
        int totalFilesCount;
        IntPtr num2 = MapiEmail.AllocateAttachments(filePaths, fileNames, ref totalFilesCount);
        if (!num2.Equals((object) IntPtr.Zero))
        {
          msg.FileCount = totalFilesCount;
          msg.Files = num2;
        }
        mapiResult2 = MapiEmail.MAPISendMail(IntPtr.Zero, IntPtr.Zero, ref msg, 8, 0);
      }
      finally
      {
        if (!msg.Recipients.Equals((object) IntPtr.Zero))
        {
          Marshal.DestroyStructure(msg.Recipients, typeof (MapiEmail.MapiRecipient));
          Marshal.FreeHGlobal(msg.Recipients);
        }
        if (!msg.Files.Equals((object) IntPtr.Zero))
        {
          Marshal.DestroyStructure(msg.Files, typeof (MapiEmail.MapiFile));
          Marshal.FreeHGlobal(msg.Files);
        }
      }
      mapiResult1 = mapiResult2;
    }
    return mapiResult1;
  }

  public enum AttachmentOptions
  {
    None,
    CollateAttachments,
    ZipAttachments,
  }

  private struct MapiFile
  {
    public int Reserved;
    public int Flags;
    public int Position;
    public string PathName;
    public string FileName;
    public IntPtr FileType;
  }

  private struct MapiMessage
  {
    public int Reserved;
    public string Subject;
    public string NoteText;
    public string MessageType;
    public string DateReceived;
    public string ConversationID;
    public int Flags;
    public IntPtr Originator;
    public int RecipientCount;
    public IntPtr Recipients;
    public int FileCount;
    public IntPtr Files;
  }

  private struct MapiRecipient
  {
    public int Reserved;
    public int RecipientClass;
    public string Name;
    public string Address;
    public int EidSize;
    public IntPtr EntryId;
  }

  [Flags]
  public enum MapiResult
  {
    Success = 0,
    UserAbort = 1,
    Failure = 2,
    LogonFailure = Failure | UserAbort, // 0x00000003
    DiskFull = 4,
    InsufficientMemory = DiskFull | UserAbort, // 0x00000005
    AccessDenied = DiskFull | Failure, // 0x00000006
    TooManySessions = 8,
    TooManyFiles = TooManySessions | UserAbort, // 0x00000009
    TooManyRecipients = TooManySessions | Failure, // 0x0000000A
    AttachmentNotFound = TooManyRecipients | UserAbort, // 0x0000000B
    AttachmentOpenFailure = TooManySessions | DiskFull, // 0x0000000C
    AttachmentWriteFailure = AttachmentOpenFailure | UserAbort, // 0x0000000D
    UnknownRecipient = AttachmentOpenFailure | Failure, // 0x0000000E
    BadRecipientType = UnknownRecipient | UserAbort, // 0x0000000F
    NoMessages = 16, // 0x00000010
    InvalidMessage = NoMessages | UserAbort, // 0x00000011
    TextTooLarge = NoMessages | Failure, // 0x00000012
    InvalidSession = TextTooLarge | UserAbort, // 0x00000013
    TypeNotSupported = NoMessages | DiskFull, // 0x00000014
    AmbiguousRecipient = TypeNotSupported | UserAbort, // 0x00000015
    MessageInUse = TypeNotSupported | Failure, // 0x00000016
    NetworkFailure = MessageInUse | UserAbort, // 0x00000017
    InvalidEditFields = NoMessages | TooManySessions, // 0x00000018
    InvalidRecipients = InvalidEditFields | UserAbort, // 0x00000019
    NotSupported = InvalidEditFields | Failure, // 0x0000001A
  }
}
