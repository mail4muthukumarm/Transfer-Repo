// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.MessageObject
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.Email;

public class MessageObject
{
  private static readonly ConcurrentDictionary<string, string> _mimeTypeMap = new ConcurrentDictionary<string, string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  public const string UserPropertyNameDocSupport = "MGASystems.IMS.Email.DocSupport";
  public const string UserPropertyNameDocFolderID = "MGASystems.IMS.Email.DocFolderID";

  public MessageObject()
  {
    this.SendOutlook = OutlookSendType.None;
    this.UserProperties = new Hashtable((IEqualityComparer) StringComparer.OrdinalIgnoreCase);
    this.Recipients = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    this.CCRecipients = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    this.BCCRecipients = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    this.InlineImages = true;
    this.FileAttachments = new HashSet<string>();
  }

  internal static string FindMimeType(string filename, string defaultType = "application/unknown")
  {
    return MessageObject._mimeTypeMap.GetOrAdd(Path.GetExtension(filename), (Func<string, string>) ([SpecialName] (ext) =>
    {
      string mimeType;
      try
      {
        RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(ext);
        if (registryKey?.GetValue("Content Type") != null)
        {
          mimeType = registryKey.GetValue("Content Type").ToString();
          goto label_4;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      mimeType = defaultType;
label_4:
      return mimeType;
    }));
  }

  public OutlookSendType SendOutlook { get; set; }

  public Hashtable UserProperties { get; set; }

  public string FromAddress { get; set; }

  public HashSet<string> Recipients { get; }

  public HashSet<string> CCRecipients { get; }

  public HashSet<string> BCCRecipients { get; }

  public string Subject { get; set; }

  public string TextBody { get; set; }

  public string ImageBody { get; set; }

  public string HTMLBody { get; set; }

  public bool InlineImages { get; set; }

  public HashSet<string> FileAttachments { get; }

  public bool SetFromAddressAsSentOnBehalfOfName { get; set; }

  public string ToAddress
  {
    get => this.Recipients.FirstOrDefault<string>();
    set
    {
      if (string.IsNullOrEmpty(value))
        this.Recipients.Clear();
      else
        this.Recipients.Add(value);
    }
  }

  public string CC
  {
    get => this.CCRecipients.FirstOrDefault<string>();
    set
    {
      if (string.IsNullOrEmpty(value))
        this.CCRecipients.Clear();
      else
        this.CCRecipients.Add(value);
    }
  }

  public string BCC
  {
    get => this.BCCRecipients.FirstOrDefault<string>();
    set
    {
      if (string.IsNullOrEmpty(value))
        this.BCCRecipients.Clear();
      else
        this.BCCRecipients.Add(value);
    }
  }
}
